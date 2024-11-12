using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    [SerializeField] private float speed = 3f; // �������� ��������
    [SerializeField] private float jump_force = 7f; // ���� ������
    private bool is_grounded = false; // �� ����� �� ������

    private Rigidbody2D rigid_body; // ������ �� ���������
    private Animator animations; // ������ �� ��������� ��������
    private SpriteRenderer sprite; // ������ �� ��������� ��� ����������� ������
    
    private States State
    {
        get { return (States)animations.GetInteger("state"); } // ��������� �������� �� ���������
        set { animations.SetInteger("state", (int)value); } // ��������� ��������
    }
    private void Awake()
    {
        rigid_body = GetComponent<Rigidbody2D>(); // ��������� ����������
        animations = GetComponent<Animator>(); // ��������� ����������
        sprite = GetComponentInChildren<SpriteRenderer>(); // ��������� ���������� �� ��������� �������
    }

    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        CheckGrounded();
    }
    void Update()
    {
        if (is_grounded)
        {
            State = States.idle; // ��������� �����
        }

        if (Input.GetButton("Horizontal"))
        {
            Run();
        }
        if (is_grounded)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) // �������� �� ������� ������� ��� ������� �����
            {
                Jump();
            }
        }
    }
    private void Run()
    {
        if (is_grounded) State = States.run; // ��������� ����
        Vector3 direction = transform.right * Input.GetAxis("Horizontal"); // ����������� �� �����������
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
        // ������� ��������������, ����� �����������, ��������
        sprite.flipX = direction.x < 0.0f; // ���� ����������� < 0, �� ������� �����
    }

    private void Jump()
    {
        rigid_body.AddForce(transform.up * jump_force, ForceMode2D.Impulse);
    }

    private void CheckGrounded()
    {
        Collider2D[] collider = Physics2D.OverlapBoxAll(transform.position, new Vector2(1.4f, 0.3f),0f); // ������ �����������
        is_grounded = collider.Length > 1; // ���� ���� ��������� ��� ������, �� �� �� �����
        if (!is_grounded) State = States.jump; // ���� �� ����� �� ����� - �������
    }
}

public enum States // ������������ ���� ����� ��������
{
    idle,
    run,
    jump
}
