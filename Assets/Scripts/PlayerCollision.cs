using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement playermovement;
    public GameManager gameManager;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            playermovement.enabled = false;
            gameManager.GameOver();
        }
           


    }
}
