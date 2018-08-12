using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatControllerScript : MonoBehaviour {

    public Transform m_COM;                         // center of mass child object
    [Space(15)]
    public float thrust = 1.0f;

    Rigidbody2D rb2d;
    float horizontalInput;
    bool inputFlag;


    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        inputFlag = false;
    }

    void Update () {
        //InputFlagging();
        Balance();
        Movement();
	}

    void InputFlagging()
    {
        if ((Input.GetKey(KeyCode.LeftArrow)) || (Input.GetKey(KeyCode.RightArrow)))
            inputFlag = true;
        else
            inputFlag = false;
    }

    void Balance()
    {
        GetComponent<Rigidbody2D>().centerOfMass = m_COM.position;
    }

    void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        rb2d.AddForce(transform.right * horizontalInput * thrust);

        if (rb2d.velocity.x < 0f)
            transform.localScale = new Vector3(-1f, 1f, 1f);
        else
            transform.localScale = new Vector3(1f, 1f, 1f);
    }
}
