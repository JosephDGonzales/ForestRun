using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class FinishLine : MonoBehaviour
{
    public Victory victoryScreen;
    public InGameTimer getTime;
    Text getVictoryTime;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("The level has been completed!");
            victoryScreen.VictoryMenu();
            string getCompleteTime = PlayerPrefs.GetString("CompleteTime");
            PlayerPrefs.SetString("VictoryTime", getCompleteTime);
        }    
    }
}
