using UnityEngine;

public class Bird : MonoBehaviour
{
    public float speed = 5f; // �������� �������� �����

    private Vector2 direction;

    void Update()
    {
        // ������� ����� � �������� �����������
        transform.Translate(direction * speed * Time.deltaTime);

        // ������� �����, ���� ��� ������� �� ������� ������
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
