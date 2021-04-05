using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HightScoreSaver : MonoBehaviour
{
    [SerializeField] public static int hightScore;

    public Text HS;

    private void Update()
    {
        hightScore = PlayerPrefs.GetInt("HightScore", 1);
        HS.text = "Higest Score " + hightScore;        
    }
    

}
