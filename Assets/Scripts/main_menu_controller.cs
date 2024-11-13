using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // название первого уровня
    [SerializeField] private string firstLevelName = "1_music";

    // функция для кнопки "Начать"
    public void StartGame()
    {
        // очищаем сохранение предыдущего уровня и начинаем игру с первого уровня
        PlayerPrefs.DeleteKey("LastLevel");
        SceneManager.LoadScene(firstLevelName);
    }

    // функция для кнопки "Продолжить"
    public void ContinueGame()
    {
        // проверяем, есть ли сохранённый уровень
        if (PlayerPrefs.HasKey("LastLevel"))
        {
            string lastLevel = PlayerPrefs.GetString("LastLevel");
            SceneManager.LoadScene(lastLevel);
        }
        else
        {
            // если нет сохранённого уровня, начинаем игру с первого уровня
            StartGame();
        }
    }

    // функция для кнопки "Выход"
    public void ExitGame()
    {
        // ыыход из игры
        Application.Quit();
    }
}


