using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aparecerDeaaparecer3 : MonoBehaviour
{
    [SerializeField] private GameObject exterior;
    [SerializeField] private GameObject interior;

    int count;
    private bool aux;

    private void Start()
    {
        count = 0;
    }

    //void OnTriggerEnter(Collider other)
    //{
    //    exterior.SetActive(false);
    //    interior.SetActive(true);
    //    if (other.CompareTag("Player"))
    //    {
    //        aux = true;
    //        //customeImage.enabled = true;
    //    }
    //    else
    //    {
    //        aux = false;
    //    }
    //}

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            exterior.SetActive(false);
            interior.SetActive(true);
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
    }

    void OnTriggerExit(Collider other)
    {
        exterior.SetActive(true);
        interior.SetActive(false);
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
        //    interior.SetActive(false);
        //}

        //if (Input.GetKeyDown(KeyCode.Space) && aux == true)
        //{
        //    interior.SetActive(true);
        //    count += 1;
        //}
    }

}
