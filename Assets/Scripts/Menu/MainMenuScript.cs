using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenSettings()
    {
        SceneManager.LoadScene(-1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
