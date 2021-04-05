using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Profile : MonoBehaviour
{   
    public Text currentScore;

    private void Awake()
    {
        currentScore.text = "Curren Score: " + Scoring.CurrentScore;    
    }
}
