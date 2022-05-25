using UnityEngine.SceneManagement;
using UnityEngine;

public class menus : MonoBehaviour
{
    public string escena;
    public void Cargar()
    {
        SceneManager.LoadScene(escena);
    }
}
