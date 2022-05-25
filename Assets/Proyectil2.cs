using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil2 : MonoBehaviour
{
    public float radius = 0.0000000001f;
    public int damageAmount = 1;
    public Animator animator;

    private void OnCollisionEnter(Collision collision)
    {

        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider nerbyObject in colliders)
        {
            if (nerbyObject.tag == "Player")
            {
                PlayerManager.TakeDamage(damageAmount);
                animator.SetTrigger("damage");
                return;
            }
        }
    }
}
