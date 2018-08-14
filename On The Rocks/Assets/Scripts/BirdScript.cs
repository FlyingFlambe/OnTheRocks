using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {

    public float speed = 3f;
    Vector3 flyDirection;
	
	void Update () {

        flyDirection = new Vector3(speed, 0f, 0f);
        transform.Translate(flyDirection * Time.deltaTime);

	}
}
