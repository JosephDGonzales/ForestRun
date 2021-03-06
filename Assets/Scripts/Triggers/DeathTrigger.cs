﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger2 : MonoBehaviour
{
    public GameOver gameOverScreen;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.SetActive(false);
            Debug.Log("Player has died!");
            gameOverScreen.GameOverMenu();
        }
    }
}
