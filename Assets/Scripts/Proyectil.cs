using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    //public GameObject impactEffect;
    public float radius = 1f;
    public int damageAmount = 1;
    public Animator animator;
    public GameObject impactEffect;
    public GameObject overlay;
    private float tiempo = 0.0f;

    private void Start()
    {
        overlay.SetActive(false);
        if (overlay == true)
        {
            overlay.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        overlay.SetActive(false);
        //poner audiomanager
        GameObject impact = Instantiate(impactEffect, transform.position, Quaternion.identity);
        Destroy(impact, 2);
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        foreach(Collider nerbyObject in colliders)
        {
            if(nerbyObject.tag == "Player")
            {
                //if (gameObject.name == "Proyectil(Clone)")
                //{
                //    Destroy(gameObject);
                //}
                PlayerManager.TakeDamage(damageAmount);
                StartCoroutine(FindObjectOfType<PlayerManager>().TakeDamage2(damageAmount));
                animator.SetTrigger("damage");
                //this.enabled = false;
                return;
            }
        }
        //Destroy(gameObject);
        //SelfDestruct();
    }

    //private void Update()
    //{
    //    Destroy(gameObject, 20.0f);
    //}

    private void Update()
    {
        if (gameObject.name == "Proyectil(Clone)")
        {
           Destroy(gameObject, 1.5f);
        }
        if (overlay == true)
        {
            tiempo += Time.deltaTime;
            if (tiempo > 5.0f)
            {
                overlay.SetActive(false);
                tiempo = 0;
            }
        }
    }

    //private void Start()
    //{
    //    StartCoroutine(SelfDestruct());
    //}

    //IEnumerator SelfDestruct()
    //{
    //    yield return new WaitForSeconds(2f);
    //    Destroy(gameObject);
    //}

}