using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OtherUserInput : MonoBehaviour
{
    public Text Result;
    private const string ExpectedResult = "67796869";

    public void Submit()
    {
        if (this.Result.text == ExpectedResult)
        {
            this.Result.color = Color.green;
            SceneManager.LoadScene("CodeGround");
        }
        else
        {
            this.Result.color = Color.red;
        }  
    }

    public void DeleteALetter()
    {
        if (this.Result.text.Length > 0)
        {
            this.Result.text = this.Result.text.Substring(0, this.Result.text.Length - 1);
        }
    }
}
