using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundHandler : MonoBehaviour
{
    private AudioSource[] mysounds;

    private AudioSource caminar;
    private AudioSource laser;

    // Start is called before the first frame update
    void Start()
    {
        mysounds = GetComponents<AudioSource>();

        caminar = mysounds[1];
        laser = mysounds[0];
    }

    public void PlayCaminar()
    {
        caminar.Play();
    }

    public void NoPlayCaminar()
    {
        caminar.Stop();
    }

    public void PlayLaser()
    {
        laser.Play();
    }
}
