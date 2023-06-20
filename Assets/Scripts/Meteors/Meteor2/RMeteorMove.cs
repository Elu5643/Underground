using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RMeteorMove : MonoBehaviour
{
    float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0.0f, 180.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Renderer>().isVisible == false)
        {
            Destroy(gameObject);
        }

        transform.Translate(speed * Time.deltaTime, -speed * Time.deltaTime, 0.0f);
    }
}
