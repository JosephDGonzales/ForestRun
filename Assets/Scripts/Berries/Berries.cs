using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Berries : MonoBehaviour
{
    public bool berryObtained;
    private int count; 

    // Start is called before the first frame update
    void Start()
    {
        berryObtained = false;
        count = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //detects if player runs into berry
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            count = count + 1;
            berryObtained = true;
            Debug.Log("Obtained a berry!");
        }
    }
}
