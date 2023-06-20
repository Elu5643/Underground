using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCreate : MonoBehaviour
{
    public GameObject star;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Instantiate", 122.0f);
        Invoke("Destroy", 150f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Instantiate()
    {
        star = Instantiate(star);
    }

    void Destroy()
    {
        Destroy(star);
    }
}
