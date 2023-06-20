using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPunchMove : MonoBehaviour
{
    public float speed = 50.0f;
    public float moveSpeed = 1.0f;
    float Extimer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Extimer += Time.deltaTime;
        if (Extimer >= 0.0f && 0.5f >= Extimer)
        {
            transform.Translate(speed * Time.deltaTime, 0.0f, 0.0f);
        }

        if (Extimer >= 1.0f && 5f >= Extimer)
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0.0f, 0.0f);
        }
    }
}
