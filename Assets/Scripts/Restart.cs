using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    private Vector3 startPosition; // ѕеременна€ дл€ хранени€ начальной позиции персонажа

    void Start()
    {
        // —охран€ем начальную позицию персонажа
        startPosition = transform.position;
    }

    void Update()
    {
        // ѕровер€ем, упал ли персонаж ниже определенной высоты
        if (transform.position.y < -10) // ћожно изменить -10 на нужное значение
        {
            ResetPosition();
        }
    }

    // ћетод дл€ возвращени€ персонажа на начальную позицию
    void ResetPosition()
    {
        transform.position = startPosition;
    }
}
