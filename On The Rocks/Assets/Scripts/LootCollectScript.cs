using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootCollectScript : MonoBehaviour {

    public bool onPier = false;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pier"))
            onPier = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Pier"))
            onPier = false;
    }
}
