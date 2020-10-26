using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;      //Prefab object

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")       //if collision with object that has the Player tag occurs
        {
            Debug.Log("Enemy spawned!");    //debug message for testing purposes
            Instantiate(enemyPrefab, new Vector3(46, 1, 0), Quaternion.identity);       //Instantiating (creating) prefab during runtime, at specified position
        }    
    }
}