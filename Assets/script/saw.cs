using System.Collections;
using System.Collections.Generic;
using Unity.Profiling;
using UnityEngine;

public class saw : MonoBehaviour
{
    public float damage;
    public float movementDistance;
    public float speed;

    private bool movingLeft;
    private float leftEdge;
    private float rightEdge;
    // Start is called before the first frame update
    void Start()
    {
        leftEdge = transform.position.x - movementDistance;
        rightEdge = transform.position.x + movementDistance;
    }

    // Update is called once per frame
    void Update()
    {
        if (movingLeft )
        {
          if(transform.position.x > leftEdge)
            {
                transform.position = new Vector3(transform.position.x - speed*Time.deltaTime, transform.position.y, transform.position.z);
            }
            else
            {
                movingLeft = false;
            }
        }
        else
        {
          if(transform.position.x<rightEdge)
            {
                transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
            }
            else
            {
                movingLeft = true;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        { collision.GetComponent<Health>().TakeDamage(damage); }
    }
}
