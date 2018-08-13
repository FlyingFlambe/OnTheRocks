using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldScript : MonoBehaviour {

    public BoxCollider2D lootTrigger;
    public float goldAmount;

    public bool isLootable;

    LootCollectScript lootCollect;
    PierScript pier;

    private void Start()
    {
        lootCollect = FindObjectOfType<LootCollectScript>();
        pier = FindObjectOfType<PierScript>();

        isLootable = false;
    }

    private void Update()
    {
        if (lootCollect.onPier && isLootable)
        {
            ScoreGold();
        }
    
    }

    void ScoreGold()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            pier.lootScore += goldAmount;
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other = lootTrigger)
        {
            isLootable = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other = lootTrigger)
        {
            isLootable = false;
        }
    }
}
