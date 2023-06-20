using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LPunchCreate : MonoBehaviour
{
    public GameObject LPunch;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Instantiate", 149.5f);
        Invoke("Destroy", 153.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Instantiate()
    {
        LPunch = Instantiate(LPunch);
    }

    void Destroy()
    {
        Destroy(LPunch);
    }
}
