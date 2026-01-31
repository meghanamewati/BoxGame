using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTrigger : MonoBehaviour
{
    
    public GameManager manager;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger detected");
        manager.LevelCompleted();
    }
}

