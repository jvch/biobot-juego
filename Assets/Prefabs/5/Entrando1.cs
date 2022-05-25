using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Entrando1 : MonoBehaviour
{
    public int damageAmountB2 = -1;
    [SerializeField] private GameObject capsula2;
    
    [SerializeField] private Image customeImage2;
    //[SerializeField] private Image customeImage22;

    int count2;
    private bool aux2;

    private void Start()
    {
        count2 = 0;
    }

    void OnTriggerEnter(Collider other2)
    {
        //customeImage2.enabled = true;
        if (other2.CompareTag("Player"))
        {
            aux2 = true;
            //customeImage.enabled = true;
        }
        else
        {
            aux2 = false;
        }
    }

    void OnTriggerExit(Collider other2)
    {
        //customeImage22.enabled = false;
        //customeImage2.enabled = false;
        if (other2.CompareTag("Player"))
        {
            aux2 = false;
            //customeImage.enabled = false;
        }
    }

    void Update()
    {
        //if (count2 % 2 != 0)
        //{
        //    customeImage2.enabled = false;
        //}

        if (Input.GetKeyDown(KeyCode.Space) && aux2 == true && customeImage2.enabled == true)
        {
            //customeImage2.enabled = false;
            Destroy(customeImage2);
            //count2 += 1;
            PlayerManager.TakeDamage(damageAmountB2);
            capsula2.SetActive(true);
            return;
        }
    }

}
