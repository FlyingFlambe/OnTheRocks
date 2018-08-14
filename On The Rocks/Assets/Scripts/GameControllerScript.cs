using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControllerScript : MonoBehaviour {

    public Image logo;
    public GameObject spawner;
    public GameObject time;
    [Space(10)]

    public Text startText;
    public Text teamText;
    public Text tutorial1Text;
    public Text tutorial2Text;
    public Text lootScoreText;
    public Image lootScoreImage;
    public Text restartText;
    [Space(15)]

    GoldSpawnScript goldSpawning;
    TimerScript timer;
    BannerAnimScript banner;

    public bool enableTimer = false;
    public bool enablePier = false;
    public bool enableLooting = false;
    public bool enableMovement = false;

    float timeClock = 5f;
    bool countdown = false;


	void Start () {

        goldSpawning = FindObjectOfType<GoldSpawnScript>();
        timer = FindObjectOfType<TimerScript>();
        banner = FindObjectOfType<BannerAnimScript>();

        DisableGameplay();

	}
	
	
	void Update () {

        TutorialText();

        if (Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.Space))
        {
            EnableGameplay();
            banner.anim.SetBool("EnableGameplay", true);

            startText.color = Color.clear;
            teamText.color = Color.clear;

            lootScoreText.color = Color.black;
            lootScoreImage.color = Color.white;
        }

	}

    void EnableGameplay()
    {
        spawner.SetActive(true);
        enableTimer = true;
        enablePier = true;
        enableLooting = true;
        enableMovement = true;
    }

    void DisableGameplay()
    {
        spawner.SetActive(false);
        enableTimer = false;
        enablePier = false;
        enableLooting = false;
        enableMovement = false;
    }

    void TutorialText()
    {
        if ((Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.Space)) && countdown == false)
            countdown = true;

        if (countdown)
        {
            timeClock -= Time.deltaTime;
            tutorial1Text.color = Color.white;
        }

        if (timeClock <= 0f)
            tutorial1Text.color = Color.clear;
    }
}
