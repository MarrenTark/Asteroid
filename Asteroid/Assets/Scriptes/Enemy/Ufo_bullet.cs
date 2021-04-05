using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ufo_bullet : MonoBehaviour
{
    public int damage = 1;
    public float liveTime = 5f;

    private void Start()
    {
        Destroy(gameObject, liveTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player_Ship"))
        {
            Player_Hp_and_Die playerShip = collision.GetComponent<Player_Hp_and_Die>();
            playerShip.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
