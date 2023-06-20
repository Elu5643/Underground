using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class PlayerHPBar : MonoBehaviour
{
    public Slider slider;
    Player script;
    float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = 100;
        script = GameObject.Find("Heart").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 163.0f && 170.0f >= timer)
        {
            SceneManager.LoadScene("GameClearScene");
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            slider.value = slider.value - 10;
            if (slider.value <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("GameOverScene");
            }
        }

        if (collision.gameObject.tag == "Recovery")
        {
            slider.value = slider.value + 10;
        }

        if (collision.gameObject.tag == "NeedleMove")
        {
            if(script.Touch == true)
            {
                slider.value = slider.value - 10;
                if (slider.value <= 0)
                {
                    Destroy(gameObject);
                    SceneManager.LoadScene("GameOverScene");
                }
            }
        }

        if (collision.gameObject.tag == "NeedleStop")
        {
            if (script.Touch == false)
            {
                slider.value = slider.value - 10;
                if (slider.value <= 0)
                {
                    Destroy(gameObject);
                    SceneManager.LoadScene("GameOverScene");
                }
            }
        }
    }
}
