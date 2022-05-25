using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idleRo : StateMachineBehaviour
{
    NavMeshAgent agent;
    float timer;
    float chaseRange = 10.0f;
    Transform player;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent = animator.GetComponent<NavMeshAgent>();
        timer = 0;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent.speed = 0;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer += Time.deltaTime;
        int someint3 = Random.Range(0, 10);
        ///if (timer > 10 + ((animator.transform.position.z * someint3) / (animator.transform.position.z + 7) * 3) + ((animator.transform.position.x * 5) / (animator.transform.position.x + 7)) * 3)
         if (timer > 10)
            animator.SetBool("IsMOVING", true);


        float distance = Vector3.Distance(animator.transform.position, player.position);

        //if (distance >= 4)
        //{
            //if (distance < 6 + ((animator.transform.position.y) / (animator.transform.position.y + 7)) + ((animator.transform.position.x) / (animator.transform.position.x + 7)))
        if (distance < 3)
        {
            animator.SetBool("IsCHASING", true);
        }
        if (distance > 6)
        {
            animator.SetBool("IsCHASING", false);
        }
        //}
        //else
        //{
        //    //animator.transform.LookAt(player);
        //    animator.SetBool("IsCHASING", false);
        //}

    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent.SetDestination(agent.transform.position);
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
