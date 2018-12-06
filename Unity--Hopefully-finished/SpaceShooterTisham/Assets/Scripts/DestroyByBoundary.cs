using System.Collections;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour {

    //Destroys whatever hits the game object as it exits, creating a boundary
		void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
