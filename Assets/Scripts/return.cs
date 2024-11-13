using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMainMenu : MonoBehaviour
{
    [SerializeField] private string mainMenuSceneName = "Menu";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Сохраняем текущую сцену, чтобы потом вернуться на неё
            PlayerPrefs.SetString("LastLevel", SceneManager.GetActiveScene().name);
            PlayerPrefs.Save();

            // Переходим в главное меню
            SceneManager.LoadScene(mainMenuSceneName);
        }
    }
}
