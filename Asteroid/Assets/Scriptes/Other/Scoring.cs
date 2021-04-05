using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Scoring : MonoBehaviour
{
    public static int CurrentScore = 0;    
    
    public Text CurrentScoreText;
    public Text HP;
    private static int maxScore;

    void Start()
    {
        CurrentScore = 0;          
    }

    public static void addPoints(int points)
    {
        CurrentScore += points;
    }
    private void Update()
    {
        CurrentScoreText.text = "Score: " + CurrentScore;
        HP.text = "HP: " + Player_Hp_and_Die.playerHealth;
    }
}
