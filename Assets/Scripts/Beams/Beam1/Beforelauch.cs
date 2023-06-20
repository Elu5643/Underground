using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beforelauch : MonoBehaviour
{
    public GameObject beforelauch;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Instantiate", 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Instantiate()
    {
        beforelauch = Instantiate(beforelauch);
    }
}
