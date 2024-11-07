using UnityEngine;

public class Bird : MonoBehaviour
{
    public float speed = 5f; // Скорость движения птицы

    private Vector2 direction;

    void Update()
    {
        // Двигаем птицу в заданном направлении
        transform.Translate(direction * speed * Time.deltaTime);

        // Удаляем птицу, если она выходит за пределы экрана
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }

    public void SetDirection(Vector2 newDirection)
    {
        direction = newDirection;
    }
}
