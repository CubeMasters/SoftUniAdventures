using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HintsGiverScript : MonoBehaviour
{
    public GameObject hinterPanel;
    private Action currentAction;

    private Text textBoxOfHinter;
    private int currentMsg;
                     
    // Use this for initialization
    void Awake()
    {
        this.textBoxOfHinter = this.gameObject.GetComponent<Text>();
        this.currentMsg = -1;
    }

    //Seting the advice set by name 
    public void SetWantedAdviceSet(string adviceSetName)
    {
        hinterPanel.SetActive(true);
        if (adviceSetName == "InitialAdviceSet")
        {
            currentAction = InitialAdviceSet;  
        }                     
        currentAction();
    }

    //When next is clicked
    public void GetNextAdvice()
    {
        currentAction();
    }

    //When skip is clicked
    public void SkipCurrentAdvice()
    {
        hinterPanel.SetActive(false);
        this.currentMsg = -1;
    }

    //All the message sets
    #region  
    private void InitialAdviceSet()
    {
        this.currentMsg++;
        if (currentMsg == 0)
        {
            this.textBoxOfHinter.text = "Na maika ti potkata ";
        }
        else if (currentMsg == 1)
        {
            this.textBoxOfHinter.text = "Ne, seriozno... na maika ti potkata :D";
        }
        else
        {
            this.currentMsg = -1;
            this.hinterPanel.SetActive(false);
        }
    }

    #endregion
}
