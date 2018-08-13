using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PierScript : MonoBehaviour {

    GoldScript gold;
    LootCollectScript lootCollect;

    public float lootScore;



	void Start () {

        lootCollect = FindObjectOfType<LootCollectScript>();
	}
	
	void Update () {
        Debug.Log("Score: " + lootScore);
	}

    /*
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Loot"))
        {
            if (lootCollect.onPier && gold.isLootable)
            {

                Debug.Log("Delete loot and give score");
            }
        }
    }
    */
}
