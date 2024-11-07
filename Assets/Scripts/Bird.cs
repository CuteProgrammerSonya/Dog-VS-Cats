using UnityEngine;

public class Bird: MonoBehaviour
{
    public float speed = 2f; // �������� �������� �����
    public float flightRange = 5f; // �������� ������ (����� � ������)
    private Vector3 startPosition; // ��������� ������� �����
    private bool movingRight = true; // ����������� ��������

    private SpriteRenderer sprite; // ��������� SpriteRenderer

    void Start()
    {
        startPosition = transform.position; // ��������� ��������� �������
        sprite = GetComponentInChildren<SpriteRenderer>(); // �������� ��������� SpriteRenderer
    }

    void Update()
    {
        MoveBird();
    }

    private void MoveBird()
    {
        // ���������� ����������� ��������
        if (movingRight)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;

            // ���������, �������� �� �� ������ �������
            if (transform.position.x >= startPosition.x + flightRange)
            {
                movingRight = false; // ������ ����������� �� �����
                sprite.flipX = true; // ������������� ������
            }
        }
        else
        {
            transform.position -= Vector3.right * speed * Time.deltaTime;

            // ���������, �������� �� �� ����� �������
            if (transform.position.x <= startPosition.x - flightRange)
            {
                movingRight = true; // ������ ����������� �� ������
                sprite.flipX = false; // ������������� ������
            }
        }
    }
}
