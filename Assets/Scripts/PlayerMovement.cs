using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideForce = 500f;

	void FixedUpdate () {
        float deltaTime = Time.deltaTime;
        rb.AddForce(0, 0, forwardForce * deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * deltaTime, 0, 0, ForceMode.VelocityChange);
        }
	}
}
