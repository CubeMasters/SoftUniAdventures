using Assets.Scripts;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OtherUserInput : MonoBehaviour
{
    public Text Result;
    public GameObject hinterPanel;
    public HintsGiverScript HinterGiverScript;

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

    public void BackToGame()
    {
        SceneManager.LoadScene("CodeGround", LoadSceneMode.Single);
    }

    public void DisplayHintSet()
    {
        this.hinterPanel.SetActive(true);
        this.HinterGiverScript.SetWantedAdviceSet(AdviceSets.ASCIIHintSet);
    }
}
