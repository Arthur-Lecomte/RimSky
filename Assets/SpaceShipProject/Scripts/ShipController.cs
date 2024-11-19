using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour {

    public float speed = 100f;
    public float speedMax = 200f;

    public float rotationSpeed = 100f;

    void Update()
    {
        float currentSpeed = speed;

        if (Input.GetButton("Jump"))
            currentSpeed = speedMax;

        float rotationSpeedVertical = Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;
        float rotationSpeedHorizontal = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        
        transform.Translate(0, 0, currentSpeed * Time.deltaTime);
        transform.Rotate(rotationSpeedVertical, rotationSpeedHorizontal, 0);
    }
}
