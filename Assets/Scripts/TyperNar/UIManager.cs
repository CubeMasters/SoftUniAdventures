using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }

    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void BackToGame()
    {
        SceneManager.LoadScene("CodeGround", LoadSceneMode.Single);
    }
}
