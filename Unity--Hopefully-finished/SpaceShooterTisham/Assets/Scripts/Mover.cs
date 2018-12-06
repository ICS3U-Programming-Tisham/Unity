using System.Collections;
using UnityEngine;

public class Mover : MonoBehaviour 
{
    //Variables
	public float speed;
	private Rigidbody rb;
    
    //Gets the rigidbody component and enables the shorthand "rb"
	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

    //Moves the object
	void FixedUpdate()
	{
		rb.velocity = new Vector3(0.0f, 0.0f, speed * Time.deltaTime);
	}
}