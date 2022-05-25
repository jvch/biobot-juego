using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behavior : StateMachineBehaviour
{
    float timer;
    List<Transform> wayPoints = new List<Transform>();
    NavMeshAgent agent;

    Transform player;
    //float chaseRange = 10.0f;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        int someint2 = Random.Range(0, wayPoints.Count);
        int someint = (int)(((animator.transform.position.y + 9) / (animator.transform.position.y)) + ((animator.transform.position.x + 7) / (animator.transform.position.x)));
        if (someint < 0)
        {

        }
        if (someint < wayPoints.Count)
        {

        }
        timer = 0;
        Transform wayPointsObject = GameObject.FindGameObjectWithTag("WayPoints1").transform;
        foreach (Transform t in wayPointsObject)
            wayPoints.Add(t);

        agent = animator.GetComponent<NavMeshAgent>();
        agent.SetDestination(wayPoints[0+someint2].position);
        agent.speed = 2;

        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (agent.remainingDistance <= agent.stoppingDistance)
            agent.SetDestination(wayPoints[Random.Range(0, wayPoints.Count)].position);

        timer += Time.deltaTime;
        if (timer > 5 + ((animator.transform.position.y) / (animator.transform.position.y + 7)*3) + ((animator.transform.position.x) / (animator.transform.position.x + 7))*3)
        //if (timer > 5)
        {
            animator.SetBool("IsMOVING", false);
        }

        float distance = Vector3.Distance(animator.transform.position, player.position);
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

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent.SetDestination(agent.transform.position);
    }

}
