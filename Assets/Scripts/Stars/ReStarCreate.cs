using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReStarCreate : MonoBehaviour
{
    public GameObject Restar;
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
        Restar = Instantiate(Restar);
    }

    void Destroy()
    {
        Destroy(Restar);
    }
}
