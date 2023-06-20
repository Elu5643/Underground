using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LHandCreate : MonoBehaviour
{
    public GameObject Hand;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Instantiate", 117.5f);
        Invoke("Destroy", 119);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Instantiate()
    {
        Hand = Instantiate(Hand);
    }

    void Destroy()
    {
        Destroy(Hand);
    }
}
