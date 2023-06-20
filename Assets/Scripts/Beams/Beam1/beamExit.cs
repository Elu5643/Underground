using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beamExit : MonoBehaviour
{
    float xSpeed = 5.0f;
    float Extimer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Extimer += Time.deltaTime;
        if (Extimer >= 1.0f && 5.0f >= Extimer)
        {
            transform.Translate(xSpeed * Time.deltaTime, 0.0f,0.0f);
        }

        if (Extimer >= 5.0f)
        {
            Destroy(gameObject);
        }
    }
}