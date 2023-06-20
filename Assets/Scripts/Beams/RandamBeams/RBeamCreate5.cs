using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBeamCreate5 : MonoBehaviour
{
    public GameObject Randambeam5;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Instantiate", 127f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Instantiate()
    {
        Randambeam5 = Instantiate(Randambeam5);
    }
}

