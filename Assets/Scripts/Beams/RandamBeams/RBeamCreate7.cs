using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBeamCreate7 : MonoBehaviour
{
    public GameObject Randambeam7;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Instantiate", 129f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Instantiate()
    {
        Randambeam7 = Instantiate(Randambeam7);
    }
}
