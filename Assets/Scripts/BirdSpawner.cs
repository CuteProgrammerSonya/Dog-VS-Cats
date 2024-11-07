using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    public GameObject birdPrefab; // ������ �����
    public float spawnInterval = 10f; // �������� ��������� �����

    private void Start()
    {
        InvokeRepeating("SpawnBird", 0f, spawnInterval); // ��������� ����� SpawnBird ������ 10 ������
    }

    void SpawnBird()
    {
        // ������� ����� � ��������� ������� �� ���������
        Vector3 spawnPosition = new Vector3(10f, Random.Range(-0f, 4f), 0f);
        GameObject bird = Instantiate(birdPrefab, spawnPosition, Quaternion.identity);
        bird.GetComponent<Bird>().SetDirection(Vector2.left); // ������������� ����������� ��������
    }
}