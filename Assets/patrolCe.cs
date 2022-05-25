using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrolCe : StateMachineBehaviour
{
    float timer;
    List<Transform> wayPoints = new List<Transform>();
    NavMeshAgent agent;
    Transform player;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        int someint2 = Random.Range(0, wayPoints.Count);
        timer = 0;
        Transform wayPointsObject = GameObject.FindGameObjectWithTag("WayPoints1").transform;
        foreach (Transform t in wayPointsObject)
            wayPoints.Add(t);

        agent = animator.GetComponent<NavMeshAgent>();
        agent.SetDestination(wayPoints[0 + someint2].position);
        agent.speed = 0.3f;

        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (agent.remainingDistance <= agent.stoppingDistance)
            agent.SetDestination(wayPoints[Random.Range(0, wayPoints.Count)].position);

        timer += Time.deltaTime;
        if (timer > 5 + ((animator.transform.position.y) / (animator.transform.position.y + 7) * 3) + ((animator.transform.position.x) / (animator.transform.position.x + 7)) * 3)
            //if (timer > 5)
            animator.SetBool("IsMOVING", false);

        float distance = Vector3.Distance(animator.transform.position, player.position);

        if (distance >= 4)
        {
            if (distance < 10 + ((animator.transform.position.y) / (animator.transform.position.y + 7)) + ((animator.transform.position.x) / (animator.transform.position.x + 7)))
            //if (distance < 10)
            {
                animator.SetBool("IsCHASING", true);
            }
            if (distance > 12)
            {
                animator.SetBool("IsCHASING", false);
            }
        }
        else
        {
            animator.transform.LookAt(player);
            animator.SetBool("IsCHASING", false);
        }

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
