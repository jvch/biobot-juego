using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class E1 : MonoBehaviour
{
    public GameObject panel;

    int count;
    private bool aux;

    private void Start()
    {
        count = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        //customeImage2.enabled = true;
        if (other.CompareTag("Player"))
        {
            aux = true;
            //customeImage.enabled = true;
        }
        else
        {
            aux = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        //customeImage2.enabled = false;
        //customeImage.enabled = false;
        if (other.CompareTag("Player"))
        {
            aux = false;
            //customeImage.enabled = false;
        }
    }

    void Update()
    {
        //if (count % 2 != 0)
        //{
        //    customeImage.enabled = false;
        //}

        if (Input.GetKeyDown(KeyCode.Space) && aux == true)
        {
            panel.SetActive(true);
            //count += 1;
            return;
        }
    }

}
