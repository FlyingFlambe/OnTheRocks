using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldSpawnScript : MonoBehaviour {

    public float minSpawnTime = 1f;
    public float maxSpawnTime = 2f;
    float spawnTime = 2f;
    [Space(10)]

    public Transform[] spawnPoints;
    public GameObject[] loot;
    [Space(10)]

    bool spawnGold = false;

    GameControllerScript game;
    TimerScript timer;


	void Start () {

        game = FindObjectOfType<GameControllerScript>();
        timer = FindObjectOfType<TimerScript>();
        timer.timerOn = true;
        InvokeRepeating("SpawnGold", spawnTime, spawnTime);
	}

    void SpawnGold()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        int lootIndex = Random.Range(0, loot.Length);

        Instantiate(loot[lootIndex], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
    }
}
