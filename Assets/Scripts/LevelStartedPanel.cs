using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LevelStartedPanel : MonoBehaviour
{   
    public TMP_Text LevelStartedtext;
    
    void Start()
    {   
       // Text LevelStartedtext = FindObjectOfType<Text>();
        int Activelevel =  SceneManager.GetActiveScene().buildIndex;
        LevelStartedtext.text =   $"Level {Activelevel}";
        Invoke("EndLevelStartPanel", 1.5f);
    }

    
    void EndLevelStartPanel()
    {
        this.gameObject.SetActive(false);
    }
}
