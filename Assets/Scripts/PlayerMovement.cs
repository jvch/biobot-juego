using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float speed = 2.0f;
    public float originalSpeed;
    public float rotationSpeed;
    //public GameObject run;
    bool estaCorriendo;
    Transform enemy;
    Transform enemy2;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //enemy = GameObject.FindGameObjectWithTag("Enemy").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        movementDirection.Normalize();

        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);

        //if (Input.GetButton("Correr"))
        //{
        //    //animator.SetBool("IsRUNNING", true);
        //    speed = speed * 2;
        //    //run.GetComponent<Animator>().Play("caminar2");
        //}

        if (Input.GetKey(KeyCode.Q))
        {
            enemy = GameObject.FindGameObjectWithTag("Enemy").transform;
            enemy2 = GameObject.FindGameObjectWithTag("Enemy2").transform;
            float distance = Vector3.Distance(animator.transform.position, enemy.position);
            float distance2 = Vector3.Distance(animator.transform.position, enemy2.position);
            if(distance < 8)
                if (distance < distance2)
                    animator.transform.LookAt(enemy);
                if (distance2 < distance)
                    animator.transform.LookAt(enemy2);
            animator.SetTrigger("attack");
            return;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            estaCorriendo = true;
        }
        else
        {
            estaCorriendo = false;
        }


        if (movementDirection != Vector3.zero)
        {
            if(estaCorriendo == false)
            {
                speed = originalSpeed;
                animator.SetBool("IsMOVING", true);
                animator.SetBool("IsRUNNING", false);
                //Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
                //transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
            }
            else if(estaCorriendo == true)
            {
                //animator.Play("caminar2");
                animator.SetBool("IsRUNNING", true);
                speed = (speed * 5.0f)/speed;
            }

            //animator.SetBool("IsMOVING", true);
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
        else
        {
            animator.SetBool("IsMOVING", false);
            animator.SetBool("IsRUNNING", false);
        }
    }
}
