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
		rb.velocity = new Vector3(0.0f, 0.0f, speed * Time.deltaTime);
	}
}