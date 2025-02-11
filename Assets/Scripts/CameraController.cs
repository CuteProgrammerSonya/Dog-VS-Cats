using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player; // ������ �� ������ ������
    private Vector3 pos; // ������ ��� �������� ������� ������

    private void Awake() // ������������� �������
    {
        if (!player) // ���������, �������� �� ������ ������;
                     // ���� ���, ���� ������ ���� Dog � ���� ��� Transform
            player = FindObjectOfType<Dog>().transform;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ������� ������ �� ������� ������
        pos = player.position;
        // �������� ���������� �� z ������ �� -10 ����� ������ �� ��������� � ��������� �� �����
        pos.z = -10f;
        // ������� ����������� ������ � ������� ������
        transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime);
    }
}
