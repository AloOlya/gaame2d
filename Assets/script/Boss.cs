using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    
    public int health = 10;
    public float speed = 1;
    Transform target;
    public float damage;
    float startingHealth;
    public GameObject healthBarEnemy;


    // Start is called before the first frame update
    void Start()
    {
        startingHealth = health;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health < 0)
        {
            Destroy(gameObject);
        }

        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime);

       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("fireball"))
        {
            TakeDamage(1);
        }
        
        
            if (collision.tag == "Player")
            { collision.GetComponent<Health>().TakeDamage(damage); }
        

    }

    public void TakeDamage(int _damage)
    {
        health = health - _damage;
        if (health <= 0)
        {
            Destroy();
        }
    }
    private void Destroy()
    {
        Destroy(gameObject);
    }

    private void Flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
    public void Damage(float damage)
    {


        healthBarEnemy.transform.localScale = new Vector2(health / startingHealth, 1);
            
            }
}