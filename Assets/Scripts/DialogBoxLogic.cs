using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogBoxLogic : MonoBehaviour
{
    public string pregunta;
    public string respuesta1;
    public string respuesta2;
    public string respuesta3;
    public string respuesta4;
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
        if (count%2 == 0 || distancia > 3)
        {
            PopUpSystem pop = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PopUpSystem>();
            pop.PopUpNo();
        }

        if(Input.GetKeyDown(KeyCode.Space) && distancia < 2)
        {
            PopUpSystem pop = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PopUpSystem>();
            pop.PopUp(pregunta+"\n\n"+respuesta1+"\n"+respuesta2+"\n"+respuesta3+"\n"+respuesta4);
            count += 1;
        }
    }
}
