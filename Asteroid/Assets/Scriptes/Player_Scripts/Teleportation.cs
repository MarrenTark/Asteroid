using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{

    public Rigidbody2D rb;

    public float topBoard = 5f;
    public float botBoard = -5f;
    public float rightBoard = 9f;
    public float leftBoard = -9f;    

    

    
    private void teleport()
    {
        Vector2 newPos = transform.position;
        
        
        if (transform.position.x > rightBoard || transform.position.x < leftBoard)
        {
            newPos.x = transform.position.x * -1;            
        }

        if (transform.position.y > topBoard || transform.position.y < botBoard)
        {
            newPos.y = transform.position.y * -1;            
        }

        transform.position = newPos;
    }
    private void FixedUpdate()
    {
        teleport();        
    }
    
}
