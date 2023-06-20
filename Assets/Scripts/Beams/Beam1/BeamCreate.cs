using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamCreate : MonoBehaviour
{
    float Extimer = 0.0f;
    public GameObject Beamfiring;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Extimer += Time.deltaTime;

        if (Extimer >= 1.5f && Extimer <= 2.0f)
        {
            Destroy(gameObject);
            Instantiate(Beamfiring, transform.position, transform.rotation);
        }
    }
}
