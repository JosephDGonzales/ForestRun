using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //define public variables
    public static bool isMenuPaused = false;
    public GameObject PauseUI;
    public AudioListener listenAudio;

    //Start is called before the first frame update
    private void Start()
    {
        PauseUI.SetActive(false);
        listenAudio.enabled = true;
    }
    // Update is called once per frame
    void Update()
    {
       
    }

    public void Pause()
    {
        PauseUI.SetActive(true);
        Time.timeScale = 0f;
        listenAudio.enabled = false;
        isMenuPaused = true;
    }

    public void Resume()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        listenAudio.enabled = true;
        isMenuPaused = false;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
        Debug.Log("Loading menu...");
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
     public void QuitGame()
    {
        Debug.Log("Quittting Game!");
        Application.Quit();
    }
}
