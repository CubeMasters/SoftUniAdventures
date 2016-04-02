using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{

    public bool FactorielPassed = false;
    public bool FibonacciPassed = false;

	// Use this for initialization
	void Start ()
	{
	    Screen.orientation = ScreenOrientation.Landscape;         
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (this.FactorielPassed && this.FibonacciPassed)
	    {
	        SceneManager.LoadScene("CodeGround", LoadSceneMode.Single);
	    }
	}

    public void BackToGame()
    {
        SceneManager.LoadScene("CodeGround", LoadSceneMode.Single);
    }
}
