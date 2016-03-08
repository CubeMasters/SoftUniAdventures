using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FibonacciChecker : MonoBehaviour
{

    public InputField InputField;
    public GameStateManager GameStateManager;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (this.InputField.text == "89")
        {
            this.GameStateManager.FibonacciPassed = true;
            this.InputField.gameObject.SetActive(false);
        
        }
    }
}
