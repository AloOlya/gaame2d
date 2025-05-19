using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject pos1;
    public GameObject pos2;
    private Rigidbody2D rb;
    private Animator anim;
    private Transform currentPoint;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        //currentPoint = pos1.transform;
    }

    // Update is called once per frame
//    void Update()
//    {
//        //Vector2 point = currentPoint.position - transform.position;
//        if (currentPoint == pos1.transform)
//        {
//            rb.velocity = new Vector2(-speed, 0);
//        }
//        if (currentPoint == pos2.transform)
//        {
//            rb.velocity = new Vector2(speed, 0);
//        }

//        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pos2.transform)
//        {
//            //Flip();
//            currentPoint = pos1.transform;
//        }
//        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pos1.transform)
//        {
//            //Flip();
//            currentPoint = pos2.transform;
//        }
//    }
//    private void Flip()
//    {
//        Vector3 localScale = transform.localScale;
//        localScale.x *= -1;
//        transform.localScale = localScale;
//    }
//    private void OnDrawGizmos()
//    {
//        Gizmos.DrawLine(pos1.transform.position, pos2.transform.position);
//    }
//}
////private void OnTriggerEnter2D(Collider2D collision)
////    {
////        if (collision.tag == "Player")
////        {
////            collision.GetComponent<Health>().TakeDamage(damage);
////        }
////    }
}
