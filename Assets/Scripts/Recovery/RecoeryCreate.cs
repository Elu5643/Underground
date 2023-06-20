using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoeryCreate : MonoBehaviour
{
    public GameObject Recovery;
    public float createTime = 0.0f;
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
        if (Extimer >= 80.0f && 90.0f >= Extimer)
        {
            timer += Time.deltaTime;
            if (timer >= createTime && Recovery != null)
            {
                Vector3 pos = new Vector3(
                   Random.Range(-4.0f, 4.0f),
                   8.0f,
                   0.0f
                   );

                Instantiate(Recovery, pos, Quaternion.identity);
                timer = 0.0f;
            }
        }
    }
}
