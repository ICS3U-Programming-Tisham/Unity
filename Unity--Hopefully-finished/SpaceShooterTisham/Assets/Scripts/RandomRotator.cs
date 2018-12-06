using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour
{
    //variables
    public float tumble;
	private Rigidbody rb;    

	void Start ()
    {
        //Gets the rigidbody component for use, adds random rotation to the hazard
		rb = GetComponent<Rigidbody>();
        rb.angularVelocity = Random.insideUnitSphere * tumble; 
    }
}