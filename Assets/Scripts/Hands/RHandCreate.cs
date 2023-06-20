using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RHandCreate : MonoBehaviour
{
    public GameObject RHand;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Instantiate", 119);
        Invoke("Destroy", 120.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Instantiate()
    {
        RHand = Instantiate(RHand);
    }

    void Destroy()
    {
        Destroy(RHand);
    }
}
