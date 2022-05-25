using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esferaColision : MonoBehaviour
{
    public int damageAmount = 1;
    public Animator animator;
    float speed;
    private Rigidbody m_rigidbody;


    private void OnCollisionEnter(Collision col)
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        float velocity = agent.velocity.magnitude / agent.speed;
        Rigidbody rb = GetComponent<Rigidbody>();
        if (col.gameObject.tag == "Player")
        {
            if(velocity > 0)
            {
                PlayerManager.TakeDamage(damageAmount);
                StartCoroutine(FindObjectOfType<PlayerManager>().TakeDamage2(damageAmount));
                animator.SetTrigger("damage");
                return;
            }
        }
    }
}
