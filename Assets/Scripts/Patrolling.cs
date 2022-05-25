using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrolling : MonoBehaviour
{
    public Transform[] points;
    int current;
    public float speed;
    //public float rotationSpeed;
    private Animator animator;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        current = 0;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != points[current].position)
        {
            //animator.SetBool("IsMOVING", true);
            transform.position = Vector3.MoveTowards(transform.position, points[current].position, speed * Time.deltaTime);
            //Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            //transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
            //transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);
        }
        else
        {
            //animator.SetBool("IsMOVING", false);
            current = (current + 1) % points.Length;
        }
    }
}
