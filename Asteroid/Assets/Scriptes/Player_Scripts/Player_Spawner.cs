using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Spawner : MonoBehaviour
{
    public Transform Player;
    public Vector2 SpawnPlace = new Vector2(0,0);
    public static int PlayerCount;
    public int MaxPlayerCount = 1;

    public static int PlayerLives = 3;

    public Text Continues;



    void Update()
    {      
        if (PlayerLives > 0 & PlayerCount < MaxPlayerCount)
        {
            Instantiate(Player, SpawnPlace, Quaternion.identity);
            PlayerCount++;
            PlayerLives--;
            Player_Hp_and_Die.playerHealth = 5;
            Continues.text = "Continues: " + PlayerLives;
        }        
    }
}
