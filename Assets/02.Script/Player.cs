using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Sprite[] centerSp;
    public PBullet bullet;
    public Transform parent;
    public Transform bulletParent;

    private float timer;
    private int index = 0;
    public float delay;
    public float speed;

   
    void Start()
    {
        
    }

    
    void Update()
    {
        Move();
        Attack();
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");

        float y = Input.GetAxisRaw("Vertical");

        float clampX = Mathf.Clamp(transform.position.x + x, -2.5f, 2.5f);
        float clampY = Mathf.Clamp(transform.position.y + y, -4.5f, 4.5f);

        transform.position = new Vector2(clampX, clampY);


        timer = timer + Time.deltaTime;

        if (time > delay)
        {
            timer = 0;

            GetComponent<SpriteRenderer>().sprite = centerSp[index];

            index++;

            if (index >= centerSp.Length)
            {
                index = 0;
            }
        }
    }

    float fireDelay = 0.5f;
    float fireTimer;

    void Attack()
    {
        fireTimer += Time.deltaTime;
        if (fireTimer >= fireDelay && input.GetKey(KeyCode.Space))
        {
            fireTimer = 0;

            PBullet obj = Instantiate(bullet, parent);
            obj.speed = bulletSpeed;
            obj.transform.SetParent = bulletParent;
        }
    }
}
