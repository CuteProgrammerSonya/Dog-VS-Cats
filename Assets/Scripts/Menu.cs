using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // метод,начинающий игру
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // метод для выхода из игры
    public void ExitGame()
    {
        Application.Quit();
    }

    // метод для продолжения игры с крайнего уровня
    public void ContinueGame()
    {
        if (PlayerPrefs.HasKey("SavedScene"))
        {
            int savedSceneIndex = PlayerPrefs.GetInt("SavedScene");
            SceneManager.LoadScene(savedSceneIndex);
        }
        else
        {
            PlayGame();
        }
    }
}