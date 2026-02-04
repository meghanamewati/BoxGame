using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameOverButtons : MonoBehaviour
{

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void Quit()
    {
        Debug.Log("Game quit");
        Application.Quit();

    }
}
