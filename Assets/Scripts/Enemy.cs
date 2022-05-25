using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static int enemyHP = 100;
    private SoundHandler sh;
    public GameObject projectile;
    public Transform projectilePoint;
    public static Animator animator;

    private void Start()
    {
        sh = GetComponent<SoundHandler>();
    }

    public void Shoot()
    {
        sh.PlayLaser();
        Rigidbody rb = Instantiate(projectile, projectilePoint.position, Quaternion.identity).GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * 30f, ForceMode.Impulse);
        rb.AddForce(transform.up * 3, ForceMode.Impulse);
    }

    public static void TakeDamage(int damageAmount)
    {
        enemyHP -= damageAmount;
        if(enemyHP <= 0)
        {
            animator.SetTrigger("death");
            //GetComponent<CapsuleCollider>().enabled = false;
        }
        else
        {
            animator.SetTrigger("damage");
        }
    }
}
