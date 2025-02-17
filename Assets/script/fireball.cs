using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour
{ 
    public float speed;
    private bool hit;
    private float direction;
    private BoxCollider2D boxCollider;
    private Animator anim;
    private float lifeTime;

    private void Start()
    {
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        if (hit)
        {
            return;
        }
        float movementspeed = speed * Time.deltaTime * direction;

        transform.Translate(movementspeed, 0, 0);

        lifeTime += Time.deltaTime;
        if (lifeTime > 5 ) 
        { 
        Deactivate();
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        hit = true;
        boxCollider.enabled = false;
        anim.SetTrigger("explode");

                  if (collision.CompareTag("enemy"))
            {
            Deactivate();
            }
        
    }
    public void SetDirection(float _direction)
    {
        lifeTime = 0;
        direction = _direction;
        gameObject.SetActive(true);
        hit = false;

        float localScaleX = transform.localScale.x;
        if (Mathf.Sign(localScaleX) != _direction)
        {
            localScaleX = -localScaleX;
        }
        transform.localScale = new Vector3(localScaleX, transform.localScale.y, transform.localScale.z);
    }
    private void Deactivate()
    {
        gameObject.SetActive(false);
    }
    
}
