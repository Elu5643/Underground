using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    public float xScale;
    float Extimer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        xScale = 9.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Extimer += Time.deltaTime;
        if (Extimer >= 32.0f && 40.0f >= Extimer)
        {
            if(xScale > 5.5f)
            {
                this.transform.localScale = new Vector3(xScale -= Time.deltaTime, 0.2f, 1.0f);
            }
        }

        if (Extimer >= 77.0f && 85.0f >= Extimer)
        {
            if (xScale < 9.0f)
            {
                this.transform.localScale = new Vector3(xScale += Time.deltaTime, 0.2f, 1.0f);
                transform.position = new Vector3(0.0f, -1.0f, 0.0f);
            }
        }
    }
}
