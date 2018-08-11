using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody2D))]
public class FloatObjectScript : MonoBehaviour {

    public float waterLevel = -2f;
    public float floatThreshold = 2.0f;
    public float waterDensity = 0.125f;
    public float downForce = 4.0f;

    float forceFactor;
    Vector2 floatForce;


	void FixedUpdate () {

        forceFactor = 1.0f - ((transform.position.y - waterLevel) / floatThreshold);

        if (forceFactor > 0.0f)
        {
            floatForce = -Physics2D.gravity * GetComponent<Rigidbody2D>().mass *
                         (forceFactor - GetComponent<Rigidbody2D>().velocity.y * waterDensity);
            floatForce += new Vector2(0.0f, -downForce * GetComponent<Rigidbody2D>().mass);

            GetComponent<Rigidbody2D>().AddForceAtPosition(floatForce, transform.position);
        }

	}
}
