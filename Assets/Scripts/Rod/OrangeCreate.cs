using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeCreate : MonoBehaviour
{
    public GameObject RodMove;
    public float createTime = 1.0f;
    float timer = 0.0f;
    float Extimer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Extimer += Time.deltaTime;
        if (Extimer >= 101.0f && 114.0f >= Extimer)
        {
            timer += Time.deltaTime;
            if (timer >= createTime && RodMove != null)
            {
                Vector3 pos = new Vector3(
                   -8.0f,
                   Random.Range(-2.0f, -4.0f),
                   20.0f
                   );

                Instantiate(RodMove, pos, Quaternion.identity);
                timer = 0.0f;
            }
        }
    }
}
