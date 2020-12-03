using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    public Key keyScript;
    public Key keyScript2;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && (keyScript.keyObtained || keyScript2.keyObtained))
        {
            gameObject.SetActive(false);
        }
    }
}