using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBeamCreate1 : MonoBehaviour
{
    public GameObject Randambeam1;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Instantiate", 123f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Instantiate()
    {
        Randambeam1 = Instantiate(Randambeam1);
    }
}
