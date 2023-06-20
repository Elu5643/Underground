using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBeamCreate : MonoBehaviour
{
    public GameObject Randambeam;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Instantiate", 122f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void Instantiate()
    {
        Randambeam = Instantiate(Randambeam);
    }
}
