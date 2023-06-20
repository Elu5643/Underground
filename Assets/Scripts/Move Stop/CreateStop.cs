using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateStop : MonoBehaviour
{
    public GameObject Stop;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Instantiate", 90.5f,3);
        Invoke("Destroy", 100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Instantiate()
    {
        Stop = Instantiate(Stop,new Vector3(-7.0f, -3.5f, 15.0f), Quaternion.identity);
    }

    void Destroy()
    {
        Destroy(gameObject);
    }
}
