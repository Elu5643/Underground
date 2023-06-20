using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBeamCreate6 : MonoBehaviour
{
    public GameObject Randambeam6;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Instantiate", 128f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Instantiate()
    {
        Randambeam6 = Instantiate(Randambeam6);
    }
}
