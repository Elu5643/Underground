using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamMove : MonoBehaviour
{
    float time = 0.0f;
    float xSpeed = 5.0f;
    float ySpeed = 15.0f;
    float rSpeed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        time += Time.deltaTime;
        if (time >= 0.0f && 1.0f >= time)
        {
            transform.Translate(0.0f, -ySpeed * Time.deltaTime,0.0f);
        }

        if (time >= 0.5f && 1.0f >= time)
        {
            transform.Rotate(0.0f, 0.0f, -rSpeed * Time.deltaTime);
        }


        if (time >= 3.0f && 4.0f >= time)
        {
            transform.Translate(xSpeed * Time.deltaTime, 0.0f,0.0f);
        }
    }
}
