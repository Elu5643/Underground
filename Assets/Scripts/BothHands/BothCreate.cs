using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BothCreate : MonoBehaviour
{
    public GameObject BothHandCreate;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Instantiate", 120.5f);
        Invoke("Destroy", 122f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Instantiate()
    {
        BothHandCreate = Instantiate(BothHandCreate);
    }

    void Destroy()
    {
        Destroy(BothHandCreate);
    }
}
