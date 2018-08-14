using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldScript : MonoBehaviour {

    public float goldAmount;
    [Space(15)]

    public float minThrowForce;
    public float maxThrowForce;
    float throwForce;
    [Space(10)]

    public float xMinThrowAngle = -2f;
    public float xMaxThrowAngle = 2f;
    public float yMinThrowAngle = 2f;
    public float yMaxThrowAngle = 10f;
    Vector2 throwAngle;
    public bool isLootable;             // Do not touch

    LootCollectScript lootCollect;
    PierScript pier;
    TimerScript timer;
    Rigidbody2D rb2d;
    

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        lootCollect = FindObjectOfType<LootCollectScript>();
        pier = FindObjectOfType<PierScript>();
        timer = FindObjectOfType<TimerScript>();

        isLootable = false;
        ThrowGold();

    }

    private void Update()
    {
        if (lootCollect.onPier && isLootable)
            ScoreGold();    
    }

    void ScoreGold()
    {
        if (Input.GetKeyDown(KeyCode.X) && timer.timerOn)
        {
            pier.lootScore += goldAmount;
            Destroy(this.gameObject);
        }
    }

    void ThrowGold()
    {
        throwForce = Random.Range(minThrowForce, maxThrowForce);
        throwAngle = new Vector2(Random.Range(xMinThrowAngle, xMaxThrowAngle), Random.Range(yMinThrowAngle, yMaxThrowAngle));

        rb2d.AddForce(throwAngle * throwForce);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isLootable = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isLootable = false;
        }
    }
}
