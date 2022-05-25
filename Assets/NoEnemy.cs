using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoEnemy : MonoBehaviour
{
    //private SoundHandler sh;
    public GameObject projectile;
    public Transform projectilePoint;

    private void Start()
    {
        //sh = GetComponent<SoundHandler>();
    }

    public void Shoot()
    {
        //sh.PlayLaser();
        Rigidbody rb = Instantiate(projectile, projectilePoint.position, Quaternion.identity).GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * 50f, ForceMode.Impulse);
        rb.AddForce(transform.up * 0, ForceMode.Impulse);
    }
}
