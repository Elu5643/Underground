using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RneedleCreate : MonoBehaviour
{
    float Extimer = 0.0f;
    public GameObject RotationAttack;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Extimer += Time.deltaTime;

        if (Extimer >= 32.0f && Extimer <= 40.0f && count == 0)
        {
            count++;
            Instantiate(RotationAttack,new Vector3(0.0f,-3.5f,15.0f), Quaternion.identity);
        }
    }
}