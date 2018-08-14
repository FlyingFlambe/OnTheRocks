using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

    public Image timeUp;
    public Text timerText;
    public float timer = 60.0f;

    public bool timerOn;


    void Update () {

        if (timer <= 0f)
        {
            timerText.text = "TIME: 0.0 s";
            timerText.color = Color.clear;
            timeUp.color = Color.white;
            timerOn = false;
        }
        else
        {
            timer -= Time.deltaTime;
            timerText.text = "TIME: " + timer.ToString("F1") + " s";
            timeUp.color = Color.clear;
            timerOn = true;
        }

	}
}
