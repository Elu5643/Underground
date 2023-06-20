using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HigthBigBeamMove : MonoBehaviour
{
    float time = 0.0f;
    float HigthSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 0.0f && 3.0f >= time)
        {
            transform.Translate(0.0f,-HigthSpeed * Time.deltaTime, 0.0f);
        }
    }
}
