using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour
{
    //How long before the object is destroyed
	public float lifetime;

    //Destroys the game object after a while
	void Start ()
	{
		Destroy (gameObject, lifetime);
	}
}
