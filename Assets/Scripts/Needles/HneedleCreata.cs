using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HneedleCreata : MonoBehaviour
{
    public GameObject Hneedleattack;
    public float createTime = 0.0000f;
    float timer = 0.0000f;
    float Extimer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Extimer += Time.deltaTime;
        if (Extimer >= 21.0f && 30.0f >= Extimer)
        {
            timer += Time.deltaTime;
            if (timer >= createTime && Hneedleattack != null)
            {
                Instantiate(Hneedleattack, new Vector3(15.0f,-2.3f,15.0f), Quaternion.identity);
                timer = 0.0f;
            }
        }
    }
}