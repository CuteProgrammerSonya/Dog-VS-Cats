using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private bool moveRight = true;
    private float speed = 2f;
    private float leftBoundary = 19.10f;
    private float rightBoundary = 20.10f;

    void Update()
    {
        // Проверка границ и смена направления
        if (transform.position.x >= rightBoundary)
        {
            moveRight = false;
        }
        else if (transform.position.x <= leftBoundary)
        {
            moveRight = true;
        }

        // Движение платформы
        float direction = moveRight ? 1 : -1;
        transform.position = new Vector2(transform.position.x + direction * speed * Time.deltaTime, transform.position.y);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        // Only attach specific objects (e.g., the player) to the moving platform
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(transform); // Set parent to the platform
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // Remove parent relationship when leaving the platform
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(null); // Remove parent
        }
    }
}
