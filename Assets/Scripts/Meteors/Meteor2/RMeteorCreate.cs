using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RMeteorCreate : MonoBehaviour
{
    public GameObject RMeteorAttack;
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
        if (Extimer >= 150.0f && 160.0f >= Extimer)
        {
            timer += Time.deltaTime;
            if (timer >= createTime && RMeteorAttack != null)
            {
                Vector3 pos = new Vector3(
                   Random.Range(15.0f, 5.0f),
                   8.0f,
                   0.0f
                   );

                Instantiate(RMeteorAttack, pos, Quaternion.identity);
                timer = 0.0f;
            }
        }
    }
}
