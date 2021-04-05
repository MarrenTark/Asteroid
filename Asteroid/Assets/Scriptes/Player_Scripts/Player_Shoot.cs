using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shoot : MonoBehaviour
{
    public Transform Bullet_Spawner;
    public GameObject bullet;

    void Shoot()
    {
        Instantiate(bullet, Bullet_Spawner.position, Bullet_Spawner.rotation);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
}
