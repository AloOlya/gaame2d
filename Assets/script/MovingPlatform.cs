using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    float dirX;
    float speed;

    bool movingRight;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        if(transform.position.x>4f)
        {
            movingRight = false;
        }
        else if (transform.position.x < -4f)
        {
            movingRight = true;
        }
        if (movingRight)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);

        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }
}
