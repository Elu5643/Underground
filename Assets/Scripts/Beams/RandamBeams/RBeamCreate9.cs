using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBeamCreate9 : MonoBehaviour
{
    public GameObject Randambeam9;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Instantiate", 131f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Instantiate()
    {
        Randambeam9 = Instantiate(Randambeam9);
    }
}
