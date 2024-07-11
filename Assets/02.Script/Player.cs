using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Sprite[] centerSp;

    private int index;
    public float delay;
    public float speed;

   
    void Start()
    {
        
    }

    
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");

        float y = Input.GetAxisRaw("Vertical");

        if((transform.position.x >= -2.5f && transform.position.x <= 2.5f)
            (transform.position.y >= -4.5f && transform.position.y <= -4.5f))
        {
            transform.Translate(new Vector2(x, y) * Time.deltaTime * speed)
        }
        else
        {
            if(transform.position.x <= -2.5f)
            {
                transform.position = new Vector2(-2.5f, transform.position.y);
            }
            else if (transform.position.x <= 2.5f)
            {
                transform.position = new Vector2(2.5f, transform.position.y);
            }
        }

        timer = timer

    }
}
