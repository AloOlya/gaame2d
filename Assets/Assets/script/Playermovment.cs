using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovment : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
       body = GetComponent <Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontal*speed, body.velocity.y);
        if (Input.GetKey(KeyCode.Space))
            {
              body.velocity = new Vector2(body.velocity.x,speed);
            }
        if (horizontal > 0.01f)
        {
            transform.localScale = Vector3.one;
        }
        else if (horizontal < -0.01f)
        {
            transform.localScale = new Vector3(-1,1,1); 
        }
    }
}
