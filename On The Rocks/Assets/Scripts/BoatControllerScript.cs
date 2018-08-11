using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (FloatObjectScript))]
public class BoatControllerScript : MonoBehaviour {

    public Vector2 COM;                             // Center Of Mass
    [Space(15)]
    public float speed = 1.0f;
    public float movementThreshold = 25.0f;
    [Space(15)]
    public float rotationRate = 1.0f;
    public float rotationThreshold = 25.0f;
    public float maxRotation = 15.0f;

    Rigidbody2D rb2d;
    Transform m_COM;
    float horizontalInput;
    float movementFactor;

    float zRotation;
    float rotationSign;
    float rotationFactor;

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
        //Tilt();
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
        if (!m_COM)
        {
            m_COM = new GameObject("COM").transform;
            m_COM.SetParent(transform);
        }

        m_COM.position = COM;
        GetComponent<Rigidbody2D>().centerOfMass = m_COM.position;
    }

    void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        movementFactor = Mathf.Lerp(movementFactor, horizontalInput, Time.deltaTime / movementThreshold);
        transform.Translate(movementFactor * speed, 0.0f, 0.0f);
    }

    void Tilt()
    {
        rotationSign = Mathf.Sign(horizontalInput);
        rotationFactor = Mathf.Lerp(rotationFactor, horizontalInput, Time.deltaTime / rotationThreshold);
        transform.Rotate(0.0f, 0.0f, rotationFactor * rotationRate);
    }
}
