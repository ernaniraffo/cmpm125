using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
	public float speed = 5;

	private Rigidbody rb;
	private Ray downwardsRay;
	private float movementX;
	private float movementY;

	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody>();
		downwardsRay = new Ray(transform.position, transform.up * -1);
	}

	// Update is called once per frame
	void Update()
	{
		Debug.DrawRay(transform.position, downwardsRay.direction, Color.red);
	}

	void OnMove(InputValue movementValue)
	{
		Vector2 movementVector = movementValue.Get<Vector2>();

		movementX = movementVector.x;
		movementY = movementVector.y;
	}

	// Code for Physics
	void FixedUpdate()
	{
		Vector3 movement = new Vector3(movementX, 0.0f, movementY);
		rb.AddForce(movement * speed);
	}
}
