using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LneedleCreate : MonoBehaviour
{
    public GameObject LneedleAttack;
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
        if (Extimer >= 22.0f && 31.0f >= Extimer)
        {
            timer += Time.deltaTime;
            if (timer >= createTime && LneedleAttack != null)
            {
                Instantiate(LneedleAttack, new Vector3(-15.0f, -4.7f,15.0f), Quaternion.identity);
                timer = 0.0f;
            }
        }
    }
}
