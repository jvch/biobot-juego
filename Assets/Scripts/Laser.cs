using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Laser : MonoBehaviour
{
    public int damageAmount = 1;
    public Animator animator;
    float elapsedTime = 0f; // Counts up to repeatTime
    public float repeatTime = 3f; // Time taken to repeat in seconds
    public int escena;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerManager.TakeDamage(damageAmount);
            StartCoroutine(FindObjectOfType<PlayerManager>().TakeDamage2(damageAmount));
            animator.SetTrigger("damage");
            //SceneManager.LoadScene(escena);
            return;
        }
    }

}
