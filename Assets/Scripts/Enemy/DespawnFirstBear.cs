using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnFirstBear : MonoBehaviour
{
    public GameObject enemyPrefab;      //Game object for enemy prefab

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") //if there is a collision with the object that has the Player tag
        {
            Debug.Log("First Enemy despawned!");  //Display debug message for testing purposes
            enemyPrefab.SetActive(false);  //Deactivate the first enemy when the player collides with this trigger 
        }
    }
}
