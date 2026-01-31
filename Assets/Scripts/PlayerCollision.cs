using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement playermovement; 
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy") 
            playermovement.enabled = false;
       // FindObjectOfType<GameOver>().GameEnded();


    }
}
