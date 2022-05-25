using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaextra : MonoBehaviour
{
    public int damageAmount = -1;
    public float radius = 0.0000000001f;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerManager.TakeDamage(damageAmount);
            Destroy(gameObject);
            return;
        }
    }
}
