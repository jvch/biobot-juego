using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//autorefresh test

public class Jugador : MonoBehaviour
{
    Vector3 Vec;

    [SerializeField] private Transform groundCheckTransform;
    [SerializeField] private LayerMask playerMask;

    private bool jumpKeyWasPressed;
    private float horizontalInput;
    private Rigidbody rigidbodyComponent;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWasPressed = true;
        }
        horizontalInput = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        //if (Physics.OverlapSphere(groundCheckTransform.position, 0.1f, playerMask).Length == 0)
        //{
        //    return;
        //}

        ////if (!isGrounded)
        ////{
        ////    return;
        ////}

        //if (jumpKeyWasPressed)
        //{
        //    rigidbodyComponent.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
        //    jumpKeyWasPressed = false;
        //}

        //rigidbodyComponent.velocity = new Vector3(horizontalInput, GetComponent<Rigidbody>().velocity.y, 0);

        Vec = transform.localPosition;
        Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * 5;
        Vec.z += Input.GetAxis("Vertical") * Time.deltaTime * 5;
        transform.localPosition = Vec;

    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    isGrounded = true;
    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    isGrounded = false;
    //}

}
