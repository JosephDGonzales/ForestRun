using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public bool keyObtained;

    private void Start()
    {
        keyObtained = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            keyObtained = true;
            Debug.Log("Obtained the key!");
        }
    }
}