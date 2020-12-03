using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    public GameObject VictoryUI;
    public InGameTimer saveTime;
    public BerryCount saveBerry;
    public bool isVictory;
    public bool isVictory2;
    float win1 = 0f;
    float win2 = 0f;
    float besttime = 0f;
    float besttime2 = 0f;
    int berry1;
    int berry2;
    int bestBerry;
    int bestBerry2;

    private void Awake()
    {
        isVictory = false;
        isVictory2 = false;
    }

    private void Update()
    {
        berry1 = saveBerry.berryNum;
        win1 = saveTime.timer;
        berry2 = saveBerry.berryNum;
        win2 = saveTime.timer;
    } 

    private void Start()
    {
        bestBerry = PlayerPrefs.GetInt("numBerries1");
        besttime = PlayerPrefs.GetFloat("CompleteTime");
        bestBerry2 = PlayerPrefs.GetInt("numBerries2");
        besttime2 = PlayerPrefs.GetFloat("CompleteTime2");
    }

    public void VictoryMenu()
    {
        VictoryUI.SetActive(true);
        Time.timeScale = 0f;
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "Forestrun" && besttime == 0)
        {
            isVictory = true;
            PlayerPrefs.SetFloat("CompleteTime", win1);
            PlayerPrefs.Save();
            besttime = win1;
        }

        if (scene.name == "Forestrun 2" && besttime2 == 0)
        {
            isVictory = true;
            PlayerPrefs.SetFloat("CompleteTime2", win2);
            PlayerPrefs.Save();
            besttime2 = win2;
        }

        if (scene.name == "Forestrun" && besttime >= win1)
        {
            isVictory = true;
            PlayerPrefs.SetFloat("CompleteTime", win1);
            PlayerPrefs.Save();
            besttime = win1;
        }  
        else if (scene.name == "Forestrun 2" && besttime2 >= win2)
        {
            isVictory2 = true;         
            PlayerPrefs.SetFloat("CompleteTime2", win2);
            PlayerPrefs.Save();
            besttime2 = win2;
        }

        if (scene.name == "Forestrun" && berry1 > bestBerry)
        {
            isVictory = true;
            PlayerPrefs.SetInt("numBerries1", berry1);
            PlayerPrefs.Save();
            bestBerry = berry1;
        }
        else if (scene.name == "Forestrun 2" && berry2 > bestBerry2)
        {
            isVictory2 = true;
            PlayerPrefs.SetInt("numBerries2", berry2);
            PlayerPrefs.Save();
            bestBerry2 = berry2;
        }
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}

