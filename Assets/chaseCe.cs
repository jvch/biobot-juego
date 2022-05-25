using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaseCe : StateMachineBehaviour
{
    NavMeshAgent agent;
    Transform player;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent = animator.GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent.speed = 5;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.transform.LookAt(player);
        agent.SetDestination(player.position);
        float distance = Vector3.Distance(animator.transform.position, player.position);
        //if (distance < 6)
        //{
        //    animator.SetBool("IsATTACKING", true);
        //}
        if (distance < 4)
            animator.SetBool("IsCHASING", false);
        if (distance > 12)
            animator.SetBool("IsCHASING", false);
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent.SetDestination(agent.transform.position);
    }

}
