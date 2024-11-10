using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    private Vector3 startPosition; // Переменная для хранения начальной позиции персонажа

    void Start()
    {
        // Сохраняем начальную позицию персонажа
        startPosition = transform.position;
    }

    void Update()
    {
        // Проверяем, упал ли персонаж ниже определенной высоты
        if (transform.position.y < -10) // Можно изменить -10 на нужное значение
        {
            ResetPosition();
        }
    }

    // Метод для возвращения персонажа на начальную позицию
    void ResetPosition()
    {
        transform.position = startPosition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Проверяем, является ли объект врагом
        if (collision.CompareTag("enemy")) // Убедитесь, что у врагов установлен тег "Enemy"
        {
            transform.position = startPosition;
            // Здесь можно добавить логику, например, потерю здоровья или уничтожение героя
        }
    }
}
