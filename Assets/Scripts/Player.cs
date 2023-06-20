using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private Collider2D co2D;
    private Vector3 pos;

    public float Speed = 3f;
    float xSpeed = 0f;
    float ySpeed = 0f;
    public bool Touch = false;

    float Extimer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        co2D = GetComponent<Collider2D>();
        co2D.isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        Extimer += Time.deltaTime;

        if (Extimer >= 0.0f && 5.0f >= Extimer)
        {
            if (pos.y > -3.5f)
            {
                transform.Translate(0.0f, -Speed * Time.deltaTime, 0.0f);
            }
        }

        if (Extimer >= 5.0f && 200.0f >= Extimer)
        {
            co2D.isTrigger = false;
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                ySpeed = Speed;
                Touch = true;
            }
            else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                ySpeed = -Speed;
                Touch = true;
            }
            else
            {
                ySpeed = 0.0f;
                Touch = false;
            }

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                xSpeed = -Speed;
                Touch = true;
            }
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                xSpeed = Speed;
                Touch = true;
            }
            else
            {
                xSpeed = 0.0f;
                Touch = false;
            }
        }

        //Vector2 direction = new Vector2(xSpeed, ySpeed);
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(xSpeed, ySpeed);
    }
}

