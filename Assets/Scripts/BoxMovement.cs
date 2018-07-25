using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMovement : MonoBehaviour {

	public Rigidbody rb;
	public float forwardForce = 2000f;
	public float sideForce = 500f;
	// Use this for initialization
	void Start () {
		// Debug.Log("Code initialized");
		// rb.useGravity = true;
		// rb.AddForce(0, 200, 500);
	}
	
	// Update is called once per frame
	// FixedUpdate for physics included methods
	// where Update is norm
	void FixedUpdate () {
		float deltaTime = Time.deltaTime;
		Debug.Log(deltaTime);
		rb.AddForce(0, 0, forwardForce * deltaTime);
		if(Input.GetKey("d")) {
			rb.AddForce(sideForce * deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		if(Input.GetKey("a")) {
			rb.AddForce(-sideForce * deltaTime, 0, 0, ForceMode.VelocityChange);
		}
        if(rb.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
	}
}
