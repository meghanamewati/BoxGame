using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{   
    public bool gameRestarted = false;
   
    public void GameEnded() 
    {   
        if (gameRestarted == false) 
        {   
            gameRestarted = true;
            Debug.Log("gameEnded");
            Invoke("Restart", 3f);
        }
       
    }

    void Restart() 
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
