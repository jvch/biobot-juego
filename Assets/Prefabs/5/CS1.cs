using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CS1 : MonoBehaviour
{
    public string string1 = "¿Podrías ayudarme a encontrar algo?";
    public string string2 = "Está bien, tal vez luego";
    public string string3 = "¡Muchas gracias!";
    public string string4;
    public string string5;
    public GameObject TextBox;
    public GameObject Choice03;
    public GameObject Boton4;
    public GameObject Boton5;
    public GameObject Flecha;
    public GameObject Tache;
    public GameObject ElCanvas;
    public int ChoiceMade;


    public void ChoiceOption3()
    {
        TextBox.GetComponent<Text>().text = string1;
        Boton4.SetActive(true);
        Boton5.SetActive(true);
        Flecha.SetActive(false);
        ChoiceMade = 3;
    }

    public void ChoiceOptionNO()
    {
        TextBox.GetComponent<Text>().text = string2;
        Boton4.SetActive(false);
        Boton5.SetActive(false);
        Flecha.SetActive(false);
        Tache.SetActive(true);
        ChoiceMade = 1;
    }

    public void ChoiceOptionSI()
    {
        TextBox.GetComponent<Text>().text = string3;
        Boton4.SetActive(false);
        Boton5.SetActive(false);
        Flecha.SetActive(false);
        Tache.SetActive(true);
        ChoiceMade = 2;
    }

    public void ChoiceOptionTache()
    {
        ElCanvas.SetActive(false);
        ChoiceMade = 4;
    }

    // Update is called once per frame
    void Update()
    {
        if(ChoiceMade >= 1)
        {
            Choice03.SetActive(false);
        }
    }
}
