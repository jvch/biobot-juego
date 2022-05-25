using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class criaturaColision : MonoBehaviour
{
    public int damageAmount = 1;
    public Animator animator;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            PlayerManager.TakeDamage(damageAmount);
            StartCoroutine(FindObjectOfType<PlayerManager>().TakeDamage2(damageAmount));
            animator.SetTrigger("damage");
            return;
        }
    }
}
