using System.Collections;
using UnityEngine;

public class Mover : MonoBehaviour 
{

	public float speed;
	private Rigidbody rb;
	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		rb.AddForce (0, 0, speed * Time.deltaTime);
	}
}