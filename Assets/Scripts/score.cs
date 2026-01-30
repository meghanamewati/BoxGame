using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform playerTransform;
    public Text scoretext;

    void Update()
    {
        scoretext.text = playerTransform.position.z.ToString("0");
    }
}
