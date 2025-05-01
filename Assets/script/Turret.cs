using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject bulletprefab;
    public float shootingInterval = 2f;
    public GameObject shootpos;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", 0f, shootingInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void Shoot() 
    { 
    GameObject bullet  = Instantiate(bulletprefab, shootpos.transform.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, 0f);
    }
    

}
