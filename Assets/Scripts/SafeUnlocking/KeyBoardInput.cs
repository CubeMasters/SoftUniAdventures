using UnityEngine;
using UnityEngine.UI;

public class KeyBoardInput : MonoBehaviour
{           
    public Text Result;                                    

    private Text textComponent;
                    
    void Start()
    {
        this.textComponent = this.GetComponentInChildren<Text>();
    }

    public void AddDigitToResult()
    {
        if (this.Result.text.Length <= 10)
        {                                                
            this.Result.text = this.Result.text + this.textComponent.text;
        }
    }
}
