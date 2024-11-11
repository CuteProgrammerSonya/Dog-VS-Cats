using UnityEngine;

public class BirdSpawner_3 : MonoBehaviour
{
    public GameObject birdPrefab; // Префаб птицы
    public float spawnInterval = 15f; // Интервал появления птицы

    private void Start_3()
    {
        InvokeRepeating("SpawnBird", 0f, spawnInterval); // Запускаем метод SpawnBird каждые 10 секунд
    }

    void SpawnBird_3()
    {
        // Создаем птицу в случайной позиции по вертикали
        Vector3 spawnPosition = new Vector3(50f, Random.Range(-3f, 1f), 0f);
        GameObject bird = Instantiate(birdPrefab, spawnPosition, Quaternion.identity);
    }
}