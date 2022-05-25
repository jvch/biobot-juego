using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleEsfera : StateMachineBehaviour
{
    NavMeshAgent agent;
    float timer;
    Transform player;
    float chaseRange = 10.0f;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent = animator.GetComponent<NavMeshAgent>();
        timer = 0;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent.speed = 2;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer += Time.deltaTime;
        //if (timer > 10 + ((animator.transform.position.y) / (animator.transform.position.y + 7) * 3) + ((animator.transform.position.x) / (animator.transform.position.x + 7)) * 3)
        //    //if (timer > 10)
        //    //animator.transform.LookAt(player);
        //    animator.SetBool("IsMOVING", true);

        float distance = Vector3.Distance(animator.transform.position, player.position);
        if (distance < 10)
        {
            //if (distance < 10)
            if(timer > 5)
            {
                animator.SetBool("IsMOVING", true);
            }
        }
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}
