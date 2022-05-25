using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewLaserScript : MonoBehaviour
{
    private LineRenderer lr;
    [SerializeField]
    private Transform startPoint;
    //public Animator animator;
    public int damageAmount = 1;
    public float radius = 0.0000000001f;
    private Collider other;

    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        lr.SetPosition(0, startPoint.position);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, -transform.forward, out hit))
        {
            if (hit.collider)
            {
                lr.SetPosition(1, hit.point);
            }
            if (hit.transform.tag == "Player")
            {
                SceneManager.LoadScene(2);
            }
        }
        else lr.SetPosition(1, -transform.forward * 5000);


    }

    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        SceneManager.LoadScene(2);
    //    }
    //}

    //private void OnCollisionEnter(Collision collision)
    //{
    //    //poner audiomanager
    //    //GameObject impact = Instantiate(impactEffect, transform.position, Quaternion.identity);
    //    //Destroy(impact, 2);
    //    Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
    //    foreach (Collider nerbyObject in colliders)
    //    {
    //        if (nerbyObject.tag == "Player")
    //        {
    //            PlayerManager.TakeDamage(damageAmount);
    //            //animator.SetTrigger("damage");
    //            //Destroy(gameObject);
    //            return;
    //        }
    //    }
    //    //Destroy(gameObject);
    //    //SelfDestruct();
    //}
}
