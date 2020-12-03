using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoardTime : MonoBehaviour
{
    public Text LevelOneScoreText;
    public Text LevelTwoScoreText;
    public Text LevelOneBerryText;
    public Text LevelTwoBerryText;

    private void Update()
    {
        setLevelOneScore();
        setLevelTwoScore();
        setLevelOneBerries();
        setLevelTwoBerries();
    }

    public void setLevelOneScore()
    {
        LevelOneScoreText.text = PlayerPrefs.GetFloat("CompleteTime").ToString("F2");
    }

    public void setLevelTwoScore()
    {
        LevelTwoScoreText.text = PlayerPrefs.GetFloat("CompleteTime2").ToString("F2");
    }

    public void setLevelOneBerries()
    {
        LevelOneBerryText.text = PlayerPrefs.GetInt("numBerries1").ToString();
    }

    public void setLevelTwoBerries()
    {
        LevelTwoBerryText.text = PlayerPrefs.GetInt("numBerries2").ToString();
    }
}