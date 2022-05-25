using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Player : MonoBehaviour
{

    public Transform player;
    public GameObject player1;
    public Transform player2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = player.transform.position + new Vector3(-0.01f, 2.31f, -2.31f); ;// + new Vector3(-23, 18, -23);
        transform.position = player.transform.position + new Vector3(-23, 18, -23);
        if (player1.active == false)
        {
            transform.position = player2.transform.position + new Vector3(-23, 18, -23);
            player.transform.position = player2.transform.position;
            player.transform.rotation = player2.transform.rotation;
        } else
        {
            player2.transform.position = player.transform.position;
            player2.transform.rotation = player.transform.rotation;
        }
    }
}
