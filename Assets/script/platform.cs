using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class platform : MonoBehaviour
{
  public float speed =3;
    public Transform[] points;
    public int i;
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed *Time.fixedDeltaTime);
        if(Vector2.Distance(transform.position, points[i].position)<0.2f)
        {
            if(i > 0)
            {
                i = 0;
            }
            else
            {
                i = 1;
            }
        }
    }
}
