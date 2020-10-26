using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;      //Game object for enemy prefab

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy") //if there is a collision with the object that has the Enemy tag
        {
            Debug.Log("Enemy despawned!");  //Display debug message for testing purposes
            Destroy(collision.gameObject);  //Destroy the object that collided with this object's collider 
        }
    }
}
