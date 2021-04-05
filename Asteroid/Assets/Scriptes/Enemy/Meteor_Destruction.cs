using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor_Destruction : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform Meteor_Spawner;
    public GameObject Meteor_Shard_A;
    public GameObject Meteor_Shard_B;
    public int pointCost = 10;
    public int health = 2;           
    void Spawn()
    {
        Instantiate(Meteor_Shard_A, Meteor_Spawner.position, Meteor_Spawner.rotation);
        Instantiate(Meteor_Shard_B, Meteor_Spawner.position, Meteor_Spawner.rotation);        
    }
    void Die()
    {
        if (health <= 0)
        {
            Scoring.addPoints(pointCost);
            SpawnZone.objectCount--;
            Spawn();
            Destroy(gameObject);
        }
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
            SpawnZone.objectCount--;
        }
    }

}
