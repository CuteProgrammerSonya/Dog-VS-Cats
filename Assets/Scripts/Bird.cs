using UnityEngine;

public class Bird: MonoBehaviour
{
    public float speed = 2f; // Скорость движения птицы
    public float flightRange = 5f; // Диапазон полета (влево и вправо)
    private Vector3 startPosition; // Начальная позиция птицы
    private bool movingRight = true; // Направление движения

    private SpriteRenderer sprite; // Компонент SpriteRenderer

    void Start()
    {
        startPosition = transform.position; // Сохраняем начальную позицию
        sprite = GetComponentInChildren<SpriteRenderer>(); // Получаем компонент SpriteRenderer
    }

    void Update()
    {
        MoveBird();
    }

    private void MoveBird()
    {
        // Определяем направление движения
        if (movingRight)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;

            // Проверяем, достигли ли мы правой границы
            if (transform.position.x >= startPosition.x + flightRange)
            {
                movingRight = false; // Меняем направление на влево
                sprite.flipX = true; // Разворачиваем спрайт
            }
        }
        else
        {
            transform.position -= Vector3.right * speed * Time.deltaTime;

            // Проверяем, достигли ли мы левой границы
            if (transform.position.x <= startPosition.x - flightRange)
            {
                movingRight = true; // Меняем направление на вправо
                sprite.flipX = false; // Разворачиваем спрайт
            }
        }
    }
}
