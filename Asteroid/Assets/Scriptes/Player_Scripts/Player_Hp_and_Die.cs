using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_Hp_and_Die : MonoBehaviour
{
    
    public static int playerHealth = 5;
    public int startHealth = 5;
    
    
    void Die()
    {
        if (playerHealth <= 0)
        {
            if (gameObject.CompareTag("Ufo"))
            {
                SpawnZomeUfo.UfoCount--;
            }
            if (gameObject.CompareTag("Player_Ship"))
            {
                Player_Spawner.PlayerCount--;
            }
            if (gameObject.CompareTag("Player_Ship") && Player_Spawner.PlayerLives <= 0)
            {
                if (HightScoreSaver.hightScore < Scoring.CurrentScore)
                {
                    HightScoreSaver.hightScore = Scoring.CurrentScore;
                    PlayerPrefs.SetInt("HightScore", HightScoreSaver.hightScore);
                    //PlayerPrefs.Save();
                }
                SceneManager.LoadScene(2);                
            }
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player_Bullet"))
        {
            TakeDamage(1);
        }
    }
    public void TakeDamage(int damage)
    {        
        playerHealth -= damage;        
        Die();
    }    
}
