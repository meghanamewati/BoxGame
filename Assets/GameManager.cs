using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{   

    public GameObject LvlCompScreen;
    public void LevelCompleted()
    {
        Debug.Log("GameManagerEntered");
        LvlCompScreen.SetActive(true);
    }
}
