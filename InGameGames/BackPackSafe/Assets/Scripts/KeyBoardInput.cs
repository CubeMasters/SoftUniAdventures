using UnityEngine;
using System.Collections;
using System.Net.Mime;
using UnityEngine.UI;

public class KeyBoardInput : MonoBehaviour
{           
    public Text result;                                    

    private Text textComponent;
                    
    void Start()
    {
        textComponent = this.GetComponentInChildren<Text>();
    }

    public void AddDigitToResult()
    {
        if (this.result.text.Length <= 10)
        {                                                
            this.result.text = this.result.text + textComponent.text;
        }
    }
}
