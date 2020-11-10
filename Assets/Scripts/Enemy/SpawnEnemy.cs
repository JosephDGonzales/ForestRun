using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;      //Prefab object
    public Transform spawnLoc;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")       //if collision with object that has the Player tag occurs
        {
            StartCoroutine(Spawn());
        }    
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("Enemy spawned!");    //debug message for testing purposes
        Instantiate(enemyPrefab, spawnLoc.position, Quaternion.identity);       //Instantiating (creating) prefab during runtime, at specified position
    }    
}