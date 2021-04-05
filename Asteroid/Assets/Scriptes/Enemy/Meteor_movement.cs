using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor_movement : MonoBehaviour
{
    public float forceThrust = 1f;
    public float maxTorque;
    public Rigidbody2D rb;
    
    Vector2 target;
    private void Awake()
    {
        target = new Vector2(Random.Range(-4f, 4f), Random.Range(-4f, 4f));       

        Vector2 destination = target - new Vector2(transform.position.x,transform.position.y);

        rb.AddForce(destination.normalized * forceThrust, ForceMode2D.Impulse);
    } 

    
}
