using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMode : MonoBehaviour
{
    //Gets the rb component
    private Rigidbody rb;
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	//Resets the velocity of the turret to remain still, doesn't work perfectly, however
	void FixedUpdate ()
    {
        rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
	}
}
