using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBeamCreate4 : MonoBehaviour
{
    public GameObject Randambeam4;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Instantiate", 126f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Instantiate()
    {
        Randambeam4 = Instantiate(Randambeam4);
    }
}
