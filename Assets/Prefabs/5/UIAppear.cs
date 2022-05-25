using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAppear : MonoBehaviour
{
    [SerializeField] private Image customeImage;
    [SerializeField] private Image customeImage2;

    int count;
    private bool aux;

    private void Start()
    {
        count = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        customeImage2.enabled = true;
        if (other.CompareTag("Player"))
        {
            aux = true;
            //customeImage.enabled = true;
        } else
        {
            aux = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        customeImage2.enabled = false;
        customeImage.enabled = false;
        if (other.CompareTag("Player"))
        {
            aux = false;
            //customeImage.enabled = false;
        }
    }

    void Update()
    {
        if (count % 2 != 0)
        {
            customeImage.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && aux == true)
        {
            customeImage.enabled = true;
            count += 1;
        }
    }

}
