using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Needlerotation : MonoBehaviour
{
    public float Rspeed = 50.0f;

    public float xScale = 6.0f;
    public float yScale = 6.0f;

    float Extimer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Extimer += Time.deltaTime;
        if (Extimer >= 0.0f && 8.0f >= Extimer)
        {
            if (xScale > 1.5f && yScale > 1.5f)
            {
                this.transform.localScale = new Vector3(xScale -= Time.deltaTime, yScale -= Time.deltaTime, 1.0f);
            }
        }

        if (Extimer >= 5.0f && 60.0f >= Extimer)
        {
            transform.Rotate(0.0f, 0.0f, Rspeed * Time.deltaTime);
        }

        if (Extimer >= 29.0f && 31.0f >= Extimer)
        {
            if (xScale < 2.0f && yScale < 2.0f)
            {
                this.transform.localScale = new Vector3(xScale += Time.deltaTime, yScale += Time.deltaTime, 1.0f);
            }
        }

        if (Extimer >= 33.0f && 35.0f >= Extimer)
        {
            if (xScale > 1.5f && yScale > 1.5f)
            {
                this.transform.localScale = new Vector3(xScale -= Time.deltaTime, yScale -= Time.deltaTime, 1.0f);
            }
        }


        if (Extimer >= 45.0f && 53.0f >= Extimer)
        {
            if (xScale <= 6.0f && yScale <= 6.0f)
            {
                this.transform.localScale = new Vector3(xScale += Time.deltaTime, yScale += Time.deltaTime, 1.0f);
            }
        }
    }
}