using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBeamCreate8 : MonoBehaviour
{
    public GameObject Randambeam8;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Instantiate", 130f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Instantiate()
    {
        Randambeam8 = Instantiate(Randambeam8);
    }
}
