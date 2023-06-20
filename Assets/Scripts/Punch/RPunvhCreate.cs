using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPunvhCreate : MonoBehaviour
{
    public GameObject RPunch;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Instantiate", 147f);
        Invoke("Destroy", 151f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Instantiate()
    {
        RPunch = Instantiate(RPunch);
 
    }

    void Destroy()
    {
        Destroy(RPunch);
    }
}
