using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    float Extimer = 0.0f;
    int count = 0;

    public GameObject beam;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Extimer += Time.deltaTime;
        if (Extimer >= 1.6f && 1.7f >= Extimer && count == 0)
        {
            Instantiate(beam, transform.position, transform.rotation);
            count++;
        }
    }
}
