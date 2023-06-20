using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamScale : MonoBehaviour
{
    float Extimer = 0.0f;
    public float yScale = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Extimer += Time.deltaTime;
        if (Extimer >= 1.0f && 4.0f >= Extimer)
        {
            this.transform.localScale = new Vector2(3.3f, yScale -= Time.deltaTime);

            if (yScale < 0f)
            {
                Destroy(gameObject);
            }
        }
    }
}
