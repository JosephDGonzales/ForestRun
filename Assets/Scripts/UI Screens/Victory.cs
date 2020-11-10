﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    public GameObject VictoryUI;

    void Start()
    {
        StartCoroutine(ShowVictoryMenu());    
    }

    IEnumerator ShowVictoryMenu()
    {
        yield return new WaitForSeconds(300);
        VictoryMenu();
    }

    public void VictoryMenu()
    {
        VictoryUI.SetActive(true);
        Time.timeScale = 0f;
        //FindObjectOfType<AudioManagerGame>().Play("VictorySound");
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}

