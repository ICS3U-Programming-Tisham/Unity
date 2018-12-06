using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour
{
    //Variables
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	public float delay;

    //Shoots bolt after a delay, and shoots it every x (firerate) seconds
	void Start ()
	{
		InvokeRepeating ("Fire", delay, fireRate);
	}

    //Shoots the actual bolt, and makes the noise as well
	void Fire ()
	{
		Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
		GetComponent<AudioSource>().Play();
	}
}
