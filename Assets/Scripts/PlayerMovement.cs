using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float Move ;
    public float SideMove ;
    
    void FixedUpdate()
    {
        rb.AddForce(0, 0, Move * Time.deltaTime );
        Debug.Log("added force");

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce  (SideMove * Time.deltaTime , 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce (- SideMove * Time.deltaTime , 0, 0, ForceMode.VelocityChange);
        }



        
       /* if (rb.position.y < -2f) 
        {
            Debug.Log("below");
            FindObjectOfType<GameOver>().GameEnded();
        }  */


    }
}
