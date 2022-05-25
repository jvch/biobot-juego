using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu3 : MonoBehaviour
{
    public void Nivel1()
    {
        //SceneManager.LoadScene("Levels01");
        SceneManager.LoadScene("Primero");
    }
    public void Nivel2()
    {
        //SceneManager.LoadScene("Levels02");
        SceneManager.LoadScene("Entrada");
    }
    public void Nivel3()
    {
        //SceneManager.LoadScene("Levels03");
        SceneManager.LoadScene("Drenaje");
    }
    public void Nivel4()
    {
        SceneManager.LoadScene("Plaza2");
    }
    public void Nivel5()
    {
        SceneManager.LoadScene("Pasto");
    }
    public void Nivel6()
    {
        SceneManager.LoadScene("Fungi");
    }
    public void Nivel7()
    {
        SceneManager.LoadScene("Cueva");
    }
    public void Nivel8()
    {
        SceneManager.LoadScene("Laberinto");
    }
    public void Nivel9()
    {
        SceneManager.LoadScene("Labs");
    }
    public void Nivel10()
    {
        SceneManager.LoadScene("Ultimo");
    }
    public void MainMenus()
    {
        SceneManager.LoadScene("Menu");
    }

}
