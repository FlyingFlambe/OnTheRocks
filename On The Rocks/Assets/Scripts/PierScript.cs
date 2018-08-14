using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PierScript : MonoBehaviour {

    GoldScript gold;
    LootCollectScript lootCollect;

    public float lootScore;
    public Text lootText;


	void Start () {

        lootCollect = FindObjectOfType<LootCollectScript>();
	}
	
	void Update () {
        lootText.text = "" + lootScore;
	}

    // Opens and closes pier.
    void PierManager()
    {

    }

}
