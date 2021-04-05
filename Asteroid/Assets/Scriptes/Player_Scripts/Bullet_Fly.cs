using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Fly : MonoBehaviour
{
    public float bulletSpeed;
    public int bulletDamage = 1;

    public float lifeTime = 5.0f;

    public Rigidbody2D rb;
    public Vector2 moveVector;

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if ( hitInfo.CompareTag("Meteor"))
        {
            Meteor_Destruction meteor = hitInfo.GetComponent<Meteor_Destruction>();
            meteor.TakeDamage(bulletDamage);
            Destroy(gameObject);
        }
        
        else if (hitInfo.CompareTag("Ufo") || hitInfo.CompareTag("Meteor_Shard"))
        {
            LiveEnemy enemy = hitInfo.GetComponent<LiveEnemy>();
            enemy.TakeDamage(bulletDamage);
            Destroy(gameObject);
        }
        
        
    }
    void Awake()
    {
        Destroy(gameObject, lifeTime);
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    private void FixedUpdate()
    {
        rb.AddRelativeForce(Vector2.up * bulletSpeed  );
    }
}
