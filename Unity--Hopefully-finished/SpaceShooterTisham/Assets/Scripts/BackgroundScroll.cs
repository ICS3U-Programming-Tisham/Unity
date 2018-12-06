using UnityEngine;
using System.Collections;

public class BackgroundScroll : MonoBehaviour
{
    //Variables
	public float scrollSpeed;
	public float tileSizeZ;

	private Vector3 startPosition;

    //Resets the position at the start
	void Start ()
	{
		startPosition = transform.position;
	}

    //Scrolls the background
	void Update ()
	{
		float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
		transform.position = startPosition + Vector3.forward * newPosition;
	}
}