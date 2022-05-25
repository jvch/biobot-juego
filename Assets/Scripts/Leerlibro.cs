using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leerlibro : MonoBehaviour
{
    int count;
    float distancia;

    [SerializeField]
    private float range = 10.0f;

    private Transform t;
    private Transform player;

    private void Start()
    {
        count = 0;
    }

    private void Awake()
    {
        t = this.transform;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        
        distancia = Vector3.Distance(t.position, player.position);
        if (count % 2 == 0 || distancia > 3)
        {
            PopUpSystem pop = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PopUpSystem>();
            pop.PopUpNo();
            //count -= 1;
        }
        

        if (Input.GetKeyDown(KeyCode.Space) && distancia < 2)
        {
            PopUpSystem pop = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PopUpSystem>();
            pop.PopUp("");
            count += 1;
        }
    }
}
