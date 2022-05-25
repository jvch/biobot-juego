using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaseRo : StateMachineBehaviour
{
    NavMeshAgent agent;
    Transform player;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent = animator.GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent.speed = 0;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        /////////////animator.transform.LookAt(player);
        //agent.SetDestination(player.position);
        float distance = Vector3.Distance(animator.transform.position, player.position);
        //if (distance < 6)
        //{
        //    animator.SetBool("IsATTACKING", true);
        //}
        //if (distance < 2)
        //    animator.SetBool("IsCHASING", false);

        //////////Quaternion lookRotation = Quaternion.LookRotation(player.position - agent.transform.position);

        //////////float time = 0;

        //////////Quaternion initialRotation = animator.transform.rotation;
        //////////while (time < 1)
        //////////{
        //////////    animator.transform.rotation = Quaternion.Slerp(initialRotation, lookRotation, time);

        //////////    time += Time.deltaTime * 1;

        //////////    yield return null;
        //////////}
        ///

        //Vector3 direction = player.position - animator.transform.position;
        //Quaternion toRotation = Quaternion.FromToRotation(animator.transform.forward, direction);
        //animator.transform.rotation = Quaternion.Lerp(animator.transform.rotation, toRotation, 1 * Time.time);

        Vector3 relativePos = player.position - animator.transform.position;
        Quaternion toRotation = Quaternion.LookRotation(relativePos);
        animator.transform.rotation = Quaternion.Lerp(animator.transform.rotation, toRotation, 5 * Time.deltaTime);

        if (distance > 6)
            animator.SetBool("IsCHASING", false);
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent.SetDestination(agent.transform.position);
    }

}
