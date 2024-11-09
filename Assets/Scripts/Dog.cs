<<<<<<< Updated upstream
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    [SerializeField] private float speed = 3f; // скорость движения
    [SerializeField] private float jump_force = 15f; // сила прыжка
    private bool is_grounded = false; // на земле ли объект

    private Rigidbody2D rigid_body; // ссылка на компонент
    private Animator animations; // ссылка на компонент анимации
    private SpriteRenderer sprite; // ссылка на компонент где изображение собаки
    
    private States State
    {
        get { return (States)animations.GetInteger("state"); } // получение значений из аниматора
        set { animations.SetInteger("state", (int)value); } // изменение значений
    }
    private void Awake()
    {
        rigid_body = GetComponent<Rigidbody2D>(); // получение компоненты
        animations = GetComponent<Animator>(); // получение компоненты
        sprite = GetComponentInChildren<SpriteRenderer>(); // получение компоненты из дочернего объекта
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
        if (is_grounded) State = States.idle; // состояние покоя

        if (Input.GetButton("Horizontal"))
        {
            Run();
        }
        if (is_grounded)
        {
            if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow)) // проверка на нажатие пробела или стрелки вверх
            {
                Jump();
            }
        }
    }
    private void Run()
    {
        if (is_grounded) State = States.run; // состояние бега
        Vector3 direction = transform.right * Input.GetAxis("Horizontal"); // перемещение по горизонтали
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
        // текущее местоположение, место перемещения, скорость
        sprite.flipX = direction.x < 0.0f; // если направление < 0, то поворот влево
    }

    private void Jump()
    {
        rigid_body.AddForce(transform.up * jump_force, ForceMode2D.Impulse);
    }

    private void CheckGrounded()
    {
        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, 0.3f); // массив коллайдеров
        is_grounded = collider.Length > 1; // если есть коллайдер под ногами, то мы на земле
        if (!is_grounded) State = States.jump; // если не стоим на земле - прыгаем
    }
}

public enum States // перечисление всех видов анимации
{
    idle,
    run,
    jump
}
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    [SerializeField] private float speed = 3f; // скорость движения
    [SerializeField] private float jump_force = 15f; // сила прыжка
    private bool is_grounded = false; // на земле ли объект

    private Rigidbody2D rigid_body; // ссылка на компонент
    private Animator animations; // ссылка на компонент анимации
    private SpriteRenderer sprite; // ссылка на компонент где изображение собаки
    
    private States State
    {
        get { return (States)animations.GetInteger("state"); } // получение значений из аниматора
        set { animations.SetInteger("state", (int)value); } // изменение значений
    }
    private void Awake()
    {
        rigid_body = GetComponent<Rigidbody2D>(); // получение компоненты
        animations = GetComponent<Animator>(); // получение компоненты
        sprite = GetComponentInChildren<SpriteRenderer>(); // получение компоненты из дочернего объекта
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
        if (is_grounded) State = States.idle; // состояние покоя

        if (Input.GetButton("Horizontal"))
        {
            Run();
        }
        if (is_grounded)
        {
            if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow)) // проверка на нажатие пробела или стрелки вверх
            {
                Jump();
            }
        }
    }
    private void Run()
    {
        if (is_grounded) State = States.run; // состояние бега
        Vector3 direction = transform.right * Input.GetAxis("Horizontal"); // перемещение по горизонтали
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
        // текущее местоположение, место перемещения, скорость
        sprite.flipX = direction.x < 0.0f; // если направление < 0, то поворот влево
    }

    private void Jump()
    {
        rigid_body.AddForce(transform.up * jump_force, ForceMode2D.Impulse);
    }

    private void CheckGrounded()
    {
        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, 0.3f); // массив коллайдеров
        is_grounded = collider.Length > 1; // если есть коллайдер под ногами, то мы на земле
        if (!is_grounded) State = States.jump; // если не стоим на земле - прыгаем
    }
}

public enum States // перечисление всех видов анимации
{
    idle,
    run,
    jump
}
>>>>>>> Stashed changes
