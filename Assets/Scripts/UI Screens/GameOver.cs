using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverUI;
    public Button pauseButton;

    public void GameOverMenu()
    {
        GameOverUI.SetActive(true);
        Time.timeScale = 0f;
        pauseButton.interactable = false;
        //FindObjectOfType<AudioManagerGame>().Play("GameOverSound");
    }

    public void Restart()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        pauseButton.interactable = true;
        Time.timeScale = 1f;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        pauseButton.interactable = true;
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        pauseButton.interactable = true;
        Application.Quit();
    }
}

