using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZone : MonoBehaviour
{
    public GameObject objectToSpawn;
    Vector2 pos;
    public static int objectCount = 0;
    public int maxObjectCount = 5;

    public float delay = 1f;

    //Размеры спавн зон
    readonly private float topMaxX = 10f;
    readonly private float topMinX = -10f;
    readonly private float topMaxY = 7f;
    readonly private float topMinY = 5f;

    readonly private float bottomMaxX = 10f;
    readonly private float bottomMinX = -10f;
    readonly private float bottomMaxY = -7f;
    readonly private float bottomMinY = -5f;

    readonly private float leftMaxX = -11f;
    readonly private float leftMinX = -9f;
    readonly private float leftMaxY = 6f;
    readonly private float leftMinY = -6f;

    readonly private float rightMaxX = 11f;
    readonly private float rightMinX = 9f;
    readonly private float rightMaxY = 6f;
    readonly private float rightMinY = -6f;

    private int randomCount;

    private void Start()
    {
        StartCoroutine(SpawnDelay(delay));
    }
    
    private IEnumerator SpawnDelay(float delay)
    {
        while (true) { 
            if (objectCount < maxObjectCount)
            {
                randomCount = Random.Range(1, 4);
                switch (randomCount)
                {
                    case 1:
                        SpawnObjects(topMaxX, topMinX, topMaxY, topMinY);
                        break;
                    case 2:
                        SpawnObjects(bottomMaxX, bottomMinX, bottomMaxY, bottomMinY);
                        break;
                    case 3:
                        SpawnObjects(leftMaxX, leftMinX, leftMaxY, leftMinY);
                        break;
                    case 4:
                        SpawnObjects(rightMaxX, rightMinX, rightMaxY, rightMinY);
                        break;
                    default:
                        SpawnObjects(0, 0, 0, 0);
                        break;
                }
                
            }
            yield return new WaitForSeconds(delay);
        }
    }
    public void SpawnObjects(float maxX, float minX, float maxY, float minY)
    {
        float screenX = Random.Range(minX, maxX);
        float screenY = Random.Range(minY, maxY);
        pos = new Vector2(screenX, screenY);
        Instantiate(objectToSpawn, pos, Quaternion.identity);
        objectCount++;    
    }

}
