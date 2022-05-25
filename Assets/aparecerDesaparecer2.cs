using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aparecerDesaparecer2 : MonoBehaviour
{
    [SerializeField] private GameObject exterior;
    [SerializeField] private GameObject exterior1;
    [SerializeField] private GameObject exterior2;
    [SerializeField] private GameObject exterior3;
    [SerializeField] private GameObject exterior4;
    [SerializeField] private GameObject exterior5;
    [SerializeField] private GameObject exterior6;
    [SerializeField] private GameObject exterior7;
    [SerializeField] private GameObject exterior8;
    [SerializeField] private GameObject exterior9;
    [SerializeField] private GameObject exterior10;

    int count;
    private bool aux;

    private void Start()
    {
        count = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            exterior.SetActive(false);
            exterior1.SetActive(false);
            exterior2.SetActive(false);
            exterior3.SetActive(false);
            exterior4.SetActive(false);
            exterior5.SetActive(false);
            exterior6.SetActive(false);
            exterior7.SetActive(false);
            exterior8.SetActive(false);
            exterior9.SetActive(false);
            exterior10.SetActive(false);

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
        exterior.SetActive(true);
        exterior1.SetActive(true);
        exterior2.SetActive(true);
        exterior3.SetActive(true);
        exterior4.SetActive(true);
        exterior5.SetActive(true);
        exterior6.SetActive(true);
        exterior7.SetActive(true);
        exterior8.SetActive(true);
        exterior9.SetActive(true);
        exterior10.SetActive(true);
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
