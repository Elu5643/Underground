using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarRotation : MonoBehaviour
{
    float rSpeed = 6.0f;
    float time = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time >= 0.0f && 60.0f >= time)
        {
            transform.Rotate(0.0f, 0.0f, -rSpeed * Time.deltaTime);
        }
    }
}
