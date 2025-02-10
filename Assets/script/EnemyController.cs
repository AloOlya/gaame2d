using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float damage;
    public GameObject dragon;
    public GameObject pig;
    public float speed;
    private Animator anim;
    public float movementDistance;

    private bool movingLeft;
    private float leftEdge;
    private float rightEdge;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        leftEdge = transform.position.x - movementDistance;
        rightEdge = transform.position.x + movementDistance;
    }

    // Update is called once per frame
    void Update()
    {
    //    Vector2 player1 = dragon.transform.position;
    //    Vector2 vrag1 = pig.transform.position;

    //    if (Vector2.Distance(player1, vrag1) < 16)
    //    {
    //        pig.transform.position = Vector2.MoveTowards(vrag1, player1, speed * Time.deltaTime);
    //    }
        if (movingLeft)
        {
            if (transform.position.x > leftEdge)
            {
                transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
            }
            else
            {
                movingLeft = false;
            }
        }
        else
        {
            if (transform.position.x < rightEdge)
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
        if (collision.tag == "Player")
        {
            collision.GetComponent<Health>().TakeDamage(damage);
        }
    }
}
