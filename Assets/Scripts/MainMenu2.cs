using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu2 : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Levels");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Video2");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
