using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {
    //variables
    public Transform player;
    public Vector3 offset;
    //makes the camera follow the player
    void Update()
    {
        transform.position = player.position + offset;
    }

}
