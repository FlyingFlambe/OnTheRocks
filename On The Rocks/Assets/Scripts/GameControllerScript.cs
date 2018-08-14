using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControllerScript : MonoBehaviour {

    GoldSpawnScript goldSpawning;
    TimerScript timer;

    public Image logo;
    public GameObject spawner;
    public GameObject time;
    [Space(15)]

    public bool enableTimer = false;
    public bool enablePier = false;
    public bool enableLooting = false;
    public bool enableMovement = false;


	void Start () {

        goldSpawning = FindObjectOfType<GoldSpawnScript>();
        timer = FindObjectOfType<TimerScript>();

        DisableGameplay();

	}
	
	
	void Update () {
		
        if (Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            EnableGameplay();
            // logo animation
        }

	}

    void EnableGameplay()
    {
        spawner.SetActive(true);
        time.SetActive(true);
        enablePier = true;
        enableLooting = true;
        enableMovement = true;
    }

    void DisableGameplay()
    {
        spawner.SetActive(false);
        //time.SetActive(false);
        enablePier = false;
        enableLooting = false;
        enableMovement = false;
    }
}
