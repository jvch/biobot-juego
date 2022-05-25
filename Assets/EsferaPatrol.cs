using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsferaPatrol : StateMachineBehaviour
{
    float timer;
    List<Transform> wayPoints = new List<Transform>();
    NavMeshAgent agent;

    Transform player;
    //float chaseRange = 10.0f;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent = animator.GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent.speed = 5;
        timer = 0;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.transform.LookAt(player);
        agent.SetDestination(player.position);
        float distance = Vector3.Distance(animator.transform.position, player.position);

        timer += Time.deltaTime;
        if (timer > 5)
            animator.SetBool("IsMOVING", false);
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

}
