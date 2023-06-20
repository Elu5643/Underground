using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    float Extimer = 0.0f;
    public float Speed = 3f;

    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        Extimer += Time.deltaTime;
        if (Extimer >= 5.0f && 10.0f >= Extimer)
        {
            if (pos.y > -3f)
            {
                transform.Translate(0.0f, -Speed * Time.deltaTime, 0.0f);
            }
        }
    }
}
