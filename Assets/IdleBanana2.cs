using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleBanana2 : StateMachineBehaviour
{
    NavMeshAgent agent;
    float timer;
    Transform player;
    Transform proyectil;
    float chaseRange = 10.0f;
    public Quaternion originalRotationValue;


    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Vector3 posicionOriginal = animator.transform.position;
        //Quaternion toRotation2 = Quaternion.LookRotation(posicionOriginal);
        //animator.transform.LookAt(posicionOriginal);
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
        //Vector3 posicionOriginal = animator.transform.position;
        if (distance < 4)
        {
            //if (distance < 10)
            //if (timer > 5)
            //{
            animator.SetBool("IsMOVING", true);
            //}
        }
        else
        {
            animator.SetBool("IsMOVING", false);
        }
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}
