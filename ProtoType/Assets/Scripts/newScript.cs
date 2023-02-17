using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newScript : MonoBehaviour
{
    SpriteRenderer rend;
    //status
    public static float p_MaxHP = 200;
    public static float p_CurHP = 200;
    public static float p_MaxMP = 50;
    public static float p_CurMP = 50;
    public static float p_Speed = 6;
    //default

    float angle;
    Vector2 target, mouse;

    //rigid
    public static Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        MouseMove();
        Move();
    }

    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        rigid.velocity = new Vector2(h * p_Speed, v * p_Speed);
    }

    void MouseMove()
    {
        target = transform.position;
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (target.x > mouse.x)
        {
            rend.flipX = true;
        }
        else
        {
            rend.flipX = false;
        }
    }
}
