using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCreate : MonoBehaviour
{
    public GameObject RodStop;
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
        if (Extimer >= 100.0f && 115.0f >= Extimer)
        {
            timer += Time.deltaTime;
            if (timer >= createTime && RodStop != null)
            {
                Vector3 pos = new Vector3(
                   8.0f,
                   Random.Range(-2.0f, -4.0f),
                   20.0f
                   );

                Instantiate(RodStop, pos, Quaternion.identity);
                timer = 0.0f;
            }
        }
    }
}
