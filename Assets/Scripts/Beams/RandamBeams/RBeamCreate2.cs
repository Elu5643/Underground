using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBeamCreate2 : MonoBehaviour
{
    public GameObject Randambeam2;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Instantiate", 124f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Instantiate()
    {
        Randambeam2 = Instantiate(Randambeam2);
    }
}
