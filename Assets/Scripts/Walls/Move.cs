using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
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
        if (Extimer >= 40.0f && 42.0f >= Extimer)
        {
            transform.Translate(MovexSpeed * Time.deltaTime, 0.0f, 0.0f);
        }

        if (Extimer >= 43.0f && 45.0f >= Extimer)
        {
            transform.Translate(0.0f, MoveySpeed * Time.deltaTime, 0.0f);
        }

        if(Extimer >= 46.0f && 50.0f >= Extimer)
        {
            transform.Translate(-MovexSpeed * Time.deltaTime, -MoveySpeed * Time.deltaTime, 0.0f);
        }

        if(Extimer >= 51.0f && 56.0f >= Extimer)
        {
            transform.Translate(-MovexSpeed * Time.deltaTime, MoveySpeed * Time.deltaTime, 0.0f);
        }

        if (Extimer >= 57.0f && 69.0f >= Extimer)
        {
            transform.Translate(MovexSpeed * Time.deltaTime, 0.0f, 0.0f);
        }

        if (Extimer >= 70.0f && 73.0f >= Extimer)
        {
            transform.Translate(-MovexSpeed * Time.deltaTime, -MoveySpeed * Time.deltaTime, 0.0f);
        }

        if (Extimer >= 74.0f && 76.0f >= Extimer)
        {
            transform.Translate(-MovexSpeed * Time.deltaTime,0.0f, 0.0f);
        }
    }
}
