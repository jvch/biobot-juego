using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : MonoBehaviour
{
    public int damageAmount = 1;
    public Animator animator;
    private Rigidbody rigidbody;

    private void OnCollisionEnter(Collision col)
    {
        if (0 == 1)
        {
            if (col.gameObject.tag == "Player")
            {
                PlayerManager.TakeDamage(damageAmount);
                animator.SetTrigger("damage");
                return;
            }
        }
    }
}
