using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoardTime : MonoBehaviour
{
    public Text LevelOneScoreText;

    public void setLevelOneScore()
    {
        LevelOneScoreText.text = PlayerPrefs.GetString("VictoryTime");
    }
}
