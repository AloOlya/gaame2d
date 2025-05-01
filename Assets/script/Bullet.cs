using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float LifeTime;
    public float damage=1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LifeTime += Time.deltaTime;
        if (LifeTime > 0.5)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ground")
        {
            Destroy(gameObject) ;
        }
        else if(collision.tag =="Player")
        { 
            collision.GetComponent<Health>().TakeDamage(damage);
            Destroy(gameObject) ;     
        }
    }
   
}
