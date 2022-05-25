using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public int escena;
    public static int playerHP = 100;
    public TextMeshProUGUI playerHPText;
    public GameObject overlay;
    public static bool isGameOver;
    private static float tiempo = 0.0f;

    void Start()
    {
        isGameOver = false;
        playerHP = 100;
        overlay.SetActive(false);
        tiempo = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        playerHPText.text = "+" + playerHP;
        if(isGameOver)
        {
            //display gameover screen
            SceneManager.LoadScene(escena);
        }
    }

    public static void TakeDamage(int damageAmount)
    {
        //playerHP -= (damageAmount-14);
        playerHP -= (damageAmount);
        if (playerHP <= 0)
            isGameOver = true;
        if (playerHP >= 100)
            playerHP = 100;
        //overlay.SetActive(true);
    }

    public IEnumerator TakeDamage2(int damageAmount)
    {
        overlay.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        overlay.SetActive(false);
        TakeDamage3();
    }

    public void TakeDamage3()
    {
        tiempo += Time.deltaTime;
        if (tiempo > 0.5f)
        {
            overlay.SetActive(false);
        }
    }


}
