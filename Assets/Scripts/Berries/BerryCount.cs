using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BerryCount : MonoBehaviour
{
    public int berryNum = 0;
    public Text berryText;

    private void Update()
    {
        berryText.text = berryNum.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Berry")
        {
            berryNum += 1;
        }    
    }
}
