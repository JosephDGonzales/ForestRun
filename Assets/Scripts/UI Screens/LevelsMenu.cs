using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelsMenu : MonoBehaviour
{
    public Button[] Levels;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Writing this for testing
        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerPrefs.SetInt("Level", PlayerPrefs.GetInt("Level") + 1); // This line shoud be added on level win
            if (PlayerPrefs.GetInt("Level") > 2) // just for tesing that if all three levels unlocked then lock them again
            {
                PlayerPrefs.SetInt("Level", 0);
            }
            
        }
        if (PlayerPrefs.GetInt("Level") == 0)
        {
            Levels[0].interactable = false;
            Levels[1].interactable = false;
        }
        else if (PlayerPrefs.GetInt("Level") == 1)
        {
            Levels[0].interactable = true;
            Levels[1].interactable = false;
        }
        else if (PlayerPrefs.GetInt("Level") == 2)
        {
            Levels[0].interactable = true;
            Levels[1].interactable = true;
        }
    }
}
