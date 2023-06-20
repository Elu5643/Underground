using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LneedleMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Renderer>().isVisible == false)
        {
            Destroy(gameObject);
        }

        float speed = 5.0f;

        transform.Translate(new Vector2(speed * Time.deltaTime, 0.0f));
    }
}
