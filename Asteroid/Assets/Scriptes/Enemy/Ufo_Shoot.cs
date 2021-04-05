using System.Collections;
using UnityEngine;

public class Ufo_Shoot : MonoBehaviour
{
    public Transform firePoint;
    public float shootingDelay = 2f;

    public GameObject bulletPrefab;
    public float bulletSpeed = 5;    

    private Player_Moving playerTarget;

    private void Start()
    {
        playerTarget = FindObjectOfType<Player_Moving>();
        StartCoroutine(UfoDelayShoot());
    }

    private IEnumerator UfoDelayShoot()
    {
        while (true)
        {
            yield return new WaitForSeconds(shootingDelay);
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Vector2 targetDirection = (playerTarget.transform.position - firePoint.transform.position).normalized;
        bullet.GetComponent<Rigidbody2D>().AddForce(targetDirection * bulletSpeed, ForceMode2D.Impulse);        
    }
}
