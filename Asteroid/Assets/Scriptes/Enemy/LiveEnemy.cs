using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveEnemy : MonoBehaviour
{
    public int health = 2;
    public Rigidbody2D rb;
    public int pointCost = 10;
    void Die()
    {
        if (health <= 0)
        {
            if (gameObject.CompareTag("Ufo"))
            {
                Scoring.addPoints(pointCost);
                SpawnZomeUfo.UfoCount--;
            }
            else { Scoring.addPoints(pointCost); }
            Destroy(gameObject);
        }
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void TakeDamage(int damage)
    {
        health -= damage;

        Die();
    }

    private void Update()
    {
        if (rb.transform.position.x > 15 || rb.transform.position.x < -15 || rb.transform.position.y > 8 || rb.transform.position.y < -8)
        {
            Destroy(gameObject);            
        }
    }

}
