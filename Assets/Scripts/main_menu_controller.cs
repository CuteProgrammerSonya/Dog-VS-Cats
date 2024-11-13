using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // �������� ������� ������
    [SerializeField] private string firstLevelName = "1_music";

    // ������� ��� ������ "������"
    public void StartGame()
    {
        // ������� ���������� ����������� ������ � �������� ���� � ������� ������
        PlayerPrefs.DeleteKey("LastLevel");
        SceneManager.LoadScene(firstLevelName);
    }

    // ������� ��� ������ "����������"
    public void ContinueGame()
    {
        // ���������, ���� �� ���������� �������
        if (PlayerPrefs.HasKey("LastLevel"))
        {
            string lastLevel = PlayerPrefs.GetString("LastLevel");
            SceneManager.LoadScene(lastLevel);
        }
        else
        {
            // ���� ��� ����������� ������, �������� ���� � ������� ������
            StartGame();
        }
    }

    // ������� ��� ������ "�����"
    public void ExitGame()
    {
        // ����� �� ����
        Application.Quit();
    }
}


