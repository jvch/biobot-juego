using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePlayersPrefs : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
