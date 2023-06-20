using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMove : MonoBehaviour
{
    public GameObject Move;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Instantiate", 90,1.5f);
        Invoke("Destroy", 100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Instantiate()
    {
        Move = Instantiate(Move,new Vector3(7.0f,-3.5f,15.0f),Quaternion.identity);
    }

    void Destroy()
    {
        Destroy(gameObject);
    }
}
