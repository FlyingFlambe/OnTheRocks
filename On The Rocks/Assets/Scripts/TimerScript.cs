using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

    GameControllerScript game;

    public Image timeUp;
    public Text timerText;
    public float timer = 60.0f;

    public bool timerOn;


    private void Start()
    {
        game = FindObjectOfType<GameControllerScript>();
    }

    void Update () {
        if (game.enableTimer)
        {
            if (timer <= 0f)
            {
                timerText.text = "TIME: 0.0 s";
                timerText.color = Color.clear;
                timeUp.color = Color.white;
                timerOn = false;
                game.restartText.color = Color.black;
            }
            else
            {
                timer -= Time.deltaTime;
                timerText.text = "TIME: " + timer.ToString("F1") + " s";
                timeUp.color = Color.clear;
                timerOn = true;
                game.restartText.color = Color.clear;
            }
        }

        ResetTimer();

	}

    void ResetTimer()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            timer = 60f;
            timer -= Time.deltaTime;
            timerText.text = "TIME: " + timer.ToString("F1") + " s";
            timerText.color = Color.black;
            timeUp.color = Color.clear;
            timerOn = true;
        }
    }
}
