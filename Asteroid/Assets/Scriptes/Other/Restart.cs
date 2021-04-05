using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public static void Refresh()
    {
        Player_Hp_and_Die.playerHealth = 5;
        Player_Spawner.PlayerCount = 0;
        Player_Spawner.PlayerLives = 3;
        Scoring.CurrentScore = 0;
        SpawnZomeUfo.UfoCount = 0;
        SpawnZone.objectCount = 0;
        HightScoreSaver.hightScore = 11;
    }
}
