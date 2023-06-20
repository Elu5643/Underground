using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorCreate : MonoBehaviour
{
    public GameObject MeteorAttack;
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
        if (Extimer >= 15.0f && 20.0f >= Extimer)
        {
            timer += Time.deltaTime;
            if (timer >= createTime && MeteorAttack != null)
            {
                Vector3 pos = new Vector3(
                   Random.Range(-25.0f, -5.0f),
                   9.0f,
                   0.0f
                   );

                Instantiate(MeteorAttack, pos, Quaternion.identity);
                timer = 0.0f;
            }
        }
    }
}
