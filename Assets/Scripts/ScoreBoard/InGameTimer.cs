using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;
//using Packages.Rider.Editor.UnitTesting;

public class InGameTimer : MonoBehaviour
{
    public Text timerText;      //Text object within scene to be used as timer
    public Victory win;
    public string seconds;
    public float timer = 0.0f;         //setting initial value of timer

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;    //adding 1 second to the timer at each frame
        //string minutes = ((int)timer / 60).ToString();      //converting timer to minutes
        seconds = (timer).ToString("f2");       //converting timer to seconds
        timerText.text = seconds;           //setting the text of the timer to show minutes and seconds
    }
}