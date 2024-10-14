using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerattack : MonoBehaviour
{
    public float attackCooldown;
    public Transform firePoint;
    public GameObject[] fireBalls;

    private Animator anim;
    private Playermovment playermovment;
    private float cooldownTimer  = Mathf.Infinity;
    // Start is called before the first frame update
    void Start()
    {
       anim = GetComponent <Animator> ();
        playermovment = GetComponent <Playermovment> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
