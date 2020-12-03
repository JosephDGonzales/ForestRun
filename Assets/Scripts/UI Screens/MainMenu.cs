using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioListener audioListner;// Audio listener component
    public GameObject onmuiscBtn;
    public GameObject CLOSEMUSICBTN;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Music") == 1)
        {
            audioListner.enabled = false;
            onmuiscBtn.SetActive(true);
            CLOSEMUSICBTN.SetActive(false);
        }
        else
        {
            audioListner.enabled = true;
            onmuiscBtn.SetActive(false);
            CLOSEMUSICBTN.SetActive(true);
        }
    }

    public void PlayGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Forestrun");
    }

    public void PlayGame2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Forestrun 2");
    }

    public void QuitGame() // used for quitsing
    {
        Debug.Log("GAME QUIT!");
        Application.Quit();

    }
    public void OnMusic()
    {
        audioListner.enabled = true;
        PlayerPrefs.SetInt("Music", 0);

        if (Application.platform == RuntimePlatform.Android)
        {
            AudioListener.volume = 1;
            GetComponent<AudioSource>().Stop();
        }
    }
    public void OffMusic()
    {
        PlayerPrefs.SetInt("Music", 1);
        audioListner.enabled = false;

        if (Application.platform == RuntimePlatform.Android)
        {
            AudioListener.volume = 0;
            GetComponent<AudioSource>().Play();
        }
    }
}
