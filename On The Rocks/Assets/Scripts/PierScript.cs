﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PierScript : MonoBehaviour {

    GoldScript gold;
    LootCollectScript lootCollect;
    GameControllerScript game;

    public float lootScore;
    public Text lootText;
    [Space(10)]

    public SpriteRenderer[] pierStacks;

    float timeClock = 5f;
    bool countdown = false;

    void Start () {

        game = FindObjectOfType<GameControllerScript>();
        lootCollect = FindObjectOfType<LootCollectScript>();
	}
	
	void Update () {
        lootText.text = "" + lootScore;

        TutorialText();
        PierStacking();
        PierManager();
        ResetScore();
	}

    // Opens and closes pier.
    void PierManager()
    {

    }

    // Changes stack of gold on the pier based on score.
    void PierStacking()
    {
        // Stack 1
        if ((lootScore >= 0) && (lootScore < 1500))
        {
            pierStacks[0].color = Color.white;
            pierStacks[1].color = Color.clear;
            pierStacks[2].color = Color.clear;
            pierStacks[3].color = Color.clear;
            pierStacks[4].color = Color.clear;
        }

        // Stack 2
        if ((lootScore >= 1500) && (lootScore < 3000))
        {
            pierStacks[0].color = Color.clear;
            pierStacks[1].color = Color.white;
            pierStacks[2].color = Color.clear;
            pierStacks[3].color = Color.clear;
            pierStacks[4].color = Color.clear;
        }

        // Stack 3
        if ((lootScore >= 3000) && (lootScore < 4500))
        {
            pierStacks[0].color = Color.clear;
            pierStacks[1].color = Color.clear;
            pierStacks[2].color = Color.white;
            pierStacks[3].color = Color.clear;
            pierStacks[4].color = Color.clear;
        }

        // Stack 4
        if ((lootScore >= 4500) && (lootScore < 6000))
        {
            pierStacks[0].color = Color.clear;
            pierStacks[1].color = Color.clear;
            pierStacks[2].color = Color.clear;
            pierStacks[3].color = Color.white;
            pierStacks[4].color = Color.clear;
        }

        // Stack 2
        if (lootScore >= 6000)
        {
            pierStacks[0].color = Color.clear;
            pierStacks[1].color = Color.clear;
            pierStacks[2].color = Color.clear;
            pierStacks[3].color = Color.clear;
            pierStacks[4].color = Color.white;
        }
    }

    void ResetScore()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            lootScore = 0;
        }
    }

    void TutorialText()
    {
        if (countdown)
        {
            timeClock -= Time.deltaTime;
            game.tutorial2Text.color = Color.white;
        }

        if (timeClock <= 0f)
            game.tutorial2Text.color = Color.clear;

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!countdown && (game.tutorial1Text.color != Color.white))
            countdown = true;
    }
}
