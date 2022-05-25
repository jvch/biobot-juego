using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilR : MonoBehaviour
{
    //public GameObject impactEffect;
    public float radius = 1f;
    private int damageAmount = 10;
    //public Animator animator2;
    //public GameObject impactEffect;
    //public GameObject overlay2;
    private float tiempo2 = 0.0f;
    public int enemyHP = 10;

    public int playerHP2 = 100;
    public static bool isGameOver2;
    private static float tiempo3 = 0.0f;
    public Animator animator2;

    private void Start()
    {
        /**
        overlay2.SetActive(false);
        if (overlay2 == true)
        {
            overlay2.SetActive(false);
        }
        */
        isGameOver2 = false;
        playerHP2 = 100;
        tiempo2 = 0.0f;
    }

    private void OnCollisionEnter(Collision collision)
    {
        animator2.SetTrigger("damage");
        TakeDamage4(damageAmount);
        playerHP2 -= damageAmount;
        if (playerHP2 <= 0)
        {
            animator2.SetTrigger("death");
            //GetComponent<CapsuleCollider>().enabled = false;
        }
        else
        {
            animator2.SetTrigger("damage");
        }
        //overlay2.SetActive(false);
        //poner audiomanager
        //GameObject impact = Instantiate(impactEffect, transform.position, Quaternion.identity);
        //Destroy(impact, 2);
        //Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        //foreach (Collider nerbyObject in colliders)
        //{
        //    Enemy.TakeDamage(damageAmount);
        //    if (nerbyObject.tag == "Enemy")
        //    {
        //        ////if (gameObject.name == "Proyectil(Clone)")
        //        ////{
        //        ////    Destroy(gameObject);
        //        ////}
        //        Enemy.TakeDamage(damageAmount);
        //        //StartCoroutine(FindObjectOfType<PlayerManager>().TakeDamage2(damageAmount));
        //        animator.SetTrigger("damage");
        //        //this.enabled = false;
        //        return;
        //    }
        //}
        //Destroy(gameObject);
        //SelfDestruct();
    }

    //private void Update()
    //{
    //    Destroy(gameObject, 20.0f);
    //}

    private void Update()
    {
        if (gameObject.name == "ProyectilR(Clone)")
        {
            Destroy(gameObject, 0.5f);
        }
        if (isGameOver2)
        {
            //display gameover screen
            animator2.SetTrigger("death");
            animator2.enabled = false;
            
        }
        //if (enemyHP >= 0)
        //{
        //    animator.SetTrigger("death");
        //    return;
        //    //GetComponent<CapsuleCollider>().enabled = false;
        //}

        /**
        if (overlay2 == true)
        {
            tiempo2 += Time.deltaTime;
            if (tiempo2 > 5.0f)
            {
                overlay2.SetActive(false);
                tiempo2 = 0;
            }
        }
        **/
    }

    public void TakeDamage4(int damageAmount)
    {
        //playerHP -= (damageAmount-14);
        playerHP2 -= (damageAmount);
        if (playerHP2 <= 0)
            isGameOver2 = true;
        if (playerHP2 >= 100)
            playerHP2 = 100;
        //overlay.SetActive(true);
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