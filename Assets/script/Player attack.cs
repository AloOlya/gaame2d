using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerattack : MonoBehaviour
{
    public float attackCooldown;
    private Transform firePoint;
    private GameObject[] fireBalls;

    private Animator anim;
    private Playermovment playerMovment;
    private float cooldownTimer = Mathf.Infinity;
    // Start is called before the first frame update
    void Start()
    {
       anim = GetComponent<Animator>();
       playerMovment = GetComponent<Playermovment>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)&& cooldownTimer>attackCooldown && playerMovment.CanAttack())
        {
            Attack();
            
        }
        cooldownTimer = Time.deltaTime;
    }
    private void Attack()
    {
        anim.SetTrigger("attack");
        cooldownTimer = 0;


    }
    //private int FindFireball()
    //{
    //    for(int i = 0; i < fireBalls.Length; i++)
    //   {
    //       if (!fireBalls[i].activeInHierarchy)
    //        {
    //            return i;
    //       }
    //       return 0;
    //    }
    //}
}
