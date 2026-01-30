using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform tf;
    public Vector3 offset;



    void LateUpdate()
    {
        transform.position = tf.position + offset; 
    }
}
