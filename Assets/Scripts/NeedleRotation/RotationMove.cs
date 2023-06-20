using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationMove : MonoBehaviour
{
    float Extimer = 0.0f;
    public float MovexSpeed = 1.0f;
    public float MoveySpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Extimer += Time.deltaTime;
        if (Extimer >= 8.0f && 10.0f >= Extimer)
        {
            transform.Translate(MovexSpeed * Time.deltaTime, 0.0f, 0.0f);
        }

        if (Extimer >= 11.0f && 13.0f >= Extimer)
        {
            transform.Translate(0.0f, MoveySpeed * Time.deltaTime, 0.0f);
        }

        if (Extimer >= 14.0f && 18.0f >= Extimer)
        {
            transform.Translate(-MovexSpeed * Time.deltaTime, -MoveySpeed * Time.deltaTime, 0.0f);
        }

        if (Extimer >= 19.0f && 24.0f >= Extimer)
        {
            transform.Translate(-MovexSpeed * Time.deltaTime, MoveySpeed * Time.deltaTime, 0.0f);
        }

        if (Extimer >= 25.0f && 37.0f >= Extimer)
        {
            transform.Translate(MovexSpeed * Time.deltaTime, 0.0f, 0.0f);
        }

        if (Extimer >= 38.0f && 41.0f >= Extimer)
        {
            transform.Translate(-MovexSpeed * Time.deltaTime, -MoveySpeed * Time.deltaTime, 0.0f);
        }

        if (Extimer >= 42.0f && 44.0f >= Extimer)
        {
            transform.Translate(-MovexSpeed * Time.deltaTime, 0.0f, 0.0f);
        }

        if (Extimer >= 53.0f && 54.0f >= Extimer)
        {
            Destroy(gameObject);
        }
    }
}
