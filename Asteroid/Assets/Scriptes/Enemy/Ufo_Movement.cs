using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ufo_Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    private Vector2 StartPosition;
    private Vector2 pos1 = new Vector2(4, 4);
    private Vector2 pos2 = new Vector2(4, -4);
    private Vector2 pos3 = new Vector2(-4, -4);
    private Vector2 pos4 = new Vector2(-4, 4);

    public float UfoSpeed = 0.01f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartPosition = transform.position;
        StartCoroutine(TrailMoving());
    }

    private IEnumerator TrailMoving()
    {
        while (true)
        {
            for (float i = 0; i < 1; i += Time.deltaTime / 2)
            {
                transform.position = Vector2.Lerp(StartPosition, pos1, i);
                yield return null;
            }
            StartPosition = transform.position;
            for (float i = 0; i < 1; i += Time.deltaTime / 2)
            {
                transform.position = Vector2.Lerp(StartPosition, pos2, i);
                yield return null;
            }
            StartPosition = transform.position;
            for (float i = 0; i < 1; i += Time.deltaTime / 2)
            {
                transform.position = Vector2.Lerp(StartPosition, pos3, i);
                yield return null;
            }
            StartPosition = transform.position;
            for (float i = 0; i < 1; i += Time.deltaTime / 2)
            {
                transform.position = Vector2.Lerp(StartPosition, pos4, i);
                yield return null;
            }
            StartPosition = transform.position;
        }

    }






}
