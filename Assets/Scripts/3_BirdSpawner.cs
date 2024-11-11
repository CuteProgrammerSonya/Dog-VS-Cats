using UnityEngine;

public class BirdSpawner_3 : MonoBehaviour
{
    public GameObject birdPrefab; // ������ �����
    public float spawnInterval = 15f; // �������� ��������� �����

    private void Start_3()
    {
        InvokeRepeating("SpawnBird", 0f, spawnInterval); // ��������� ����� SpawnBird ������ 10 ������
    }

    void SpawnBird_3()
    {
        // ������� ����� � ��������� ������� �� ���������
        Vector3 spawnPosition = new Vector3(50f, Random.Range(-3f, 1f), 0f);
        GameObject bird = Instantiate(birdPrefab, spawnPosition, Quaternion.identity);
    }
}