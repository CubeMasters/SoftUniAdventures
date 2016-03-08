using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OtherUserInput : MonoBehaviour
{
    public Text result;
    private const string ExpectedResult = "67796869";

    public void Submit()
    {
        if (this.result.text == ExpectedResult)
        {
            this.result.color = Color.green;
            Debug.Log("Bravo be!");
        }
        else
        {
            this.result.color = Color.red;
        }  
    }

    public void DeleteALetter()
    {
        if (result.text.Length > 0)
        {
            result.text = result.text.Substring(0, result.text.Length - 1);
        }
    }
}
