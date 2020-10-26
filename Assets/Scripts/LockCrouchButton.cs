using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockCrouchButton : MonoBehaviour
{
    public Button crouchButton;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")       //if collision with object that has the Player tag occurs
        {
            crouchButton.interactable = false;
        }
    }
}
