using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
    //Variables
	public GameObject explosion;
	public GameObject playerExplosion;
	public int scoreValue;
	private GameController gameController;

    //Gets the gameController tag to initiate a gameover later on
	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindGameObjectWithTag ("GameController");
        //Gets the GC component
		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <GameController>();
		}
	}

    //Destroys Objects
	void OnTriggerEnter (Collider other)
	{
        //Disables destruction of the boundary and of other enemies
		if (other.tag == "Boundary" || other.tag == "Enemy")
		{
			return;
		}

        //Creates an explosion for the hazard
		if (explosion != null)
		{
			Instantiate(explosion, transform.position, transform.rotation);
		}

        //Creates player's explosion and destroys the player object itself
		if (other.tag == "Player")
		{
			Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            //initiates GameOver in the GC script
			gameController.GameOver();
            gameController2.GameOver();
		}
		
        //Destroys both what the hazard hit and the hazard itself
		Destroy (other.gameObject);
		Destroy (gameObject);
        //Adds score
		gameController.AddScore(scoreValue);
	}
}