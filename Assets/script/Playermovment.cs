using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovment : MonoBehaviour
{
    public float speed = 6f;
    private Rigidbody2D body;
    private Animator anim;
    //public bool grounded;
    public LayerMask groundLayer;
    public LayerMask wallLayer;
    private float wallJumpCooldown;
    private CapsuleCollider2D capsuleCollider;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        capsuleCollider = GetComponent<CapsuleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontal * speed, body.velocity.y);
        if (Input.GetKey(KeyCode.Space) && IsGrounded())
        {
            Jump();
        }
        if (horizontal > 0.01f)
        {
            transform.localScale = Vector3.one;
        }
        else if (horizontal < -0.01f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        //anim
        anim.SetBool("move", horizontal != 0);
        anim.SetBool("ground", IsGrounded());

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.tag == "ground")
        //{
        //    grounded = true;
        //}
    }
    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, speed);
        anim.SetTrigger("New Trigger");
        //grounded = false;
    }
    private bool IsGrounded() 
    {
        RaycastHit2D RaycastHit = Physics2D.BoxCast(capsuleCollider.bounds.center, capsuleCollider.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
        return RaycastHit.collider != null; 
    }
    private bool onWall()
    {
        RaycastHit2D RaycastHit = Physics2D.BoxCast(capsuleCollider.bounds.center, capsuleCollider.bounds.size, 0, new Vector2(transform.localScale.x,0), 0.1f, wallLayer);
        return RaycastHit.collider != null;
    }


}


