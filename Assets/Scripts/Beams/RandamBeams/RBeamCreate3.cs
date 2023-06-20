using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBeamCreate3 : MonoBehaviour
{
    public GameObject Randambeam3;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Instantiate", 125f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Instantiate()
    {
        Randambeam3 = Instantiate(Randambeam3);
    }
}
