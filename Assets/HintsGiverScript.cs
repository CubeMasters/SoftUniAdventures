using System;
using UnityEngine;
using System.Collections;
using Assets.Scripts;
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
    public void SetWantedAdviceSet(AdviceSets adviceSetName)
    {
        this.currentMsg = -1;
        hinterPanel.SetActive(true);
        if (adviceSetName == AdviceSets.FirstStartOfGameSet)
        {
            currentAction = FirstStarOfGameSet;
        }
        else if (adviceSetName == AdviceSets.FactorielHintSet)
        {
            currentAction = FactorielHintSet;
        }
        else if (adviceSetName == AdviceSets.FibbonacciHintSet)
        {
            currentAction = FibbonacciHintSet;
        }
        else if (adviceSetName == AdviceSets.BitManipSet)
        {
            currentAction = BitManipSet;
        }
        else if (adviceSetName == AdviceSets.ASCIIHintSet)
        {
            currentAction = ASCIIHintSet;
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
    private void FirstStarOfGameSet()
    {
        this.currentMsg++;
        if (currentMsg == 0)
        {
            this.textBoxOfHinter.text = "Hello there, noobie. I heard that you want to learn some coding skills.";
        }
        else if (currentMsg == 1)
        {
            this.textBoxOfHinter.text = "I am going to be your guide for your new life as a code wizzard.";
        }
        else if (currentMsg == 2)
        {
            this.textBoxOfHinter.text = "Try looking around and interacting with things in the hall. ";
        }
        else
        {
            this.currentMsg = -1;
            this.hinterPanel.SetActive(false);
        }
    }

    private void FactorielHintSet()
    {
        this.currentMsg++;
        if (currentMsg == 0)
        {
            this.textBoxOfHinter.text = "Try searching for the mathematical definition of \"!\".";
        }
        else if (currentMsg == 1)
        {
            this.textBoxOfHinter.text = "Have you found the definition of factoriel?";
        }
        else if (currentMsg == 2)
        {
            this.textBoxOfHinter.text = "Example: 3! = 3 * 2 * 1";
        }
        else
        {
            this.currentMsg = -1;
            this.hinterPanel.SetActive(false);
        }
    }

    private void FibbonacciHintSet()
    {
        this.currentMsg++;
        if (currentMsg == 0)
        {
            this.textBoxOfHinter.text = "Try searching for the golden ratio and how it could be generated.";
        }
        else if (currentMsg == 1)
        {
            this.textBoxOfHinter.text = "Have you found the definition of fibonacci?";
        }
        else if (currentMsg == 2)
        {
            this.textBoxOfHinter.text = "Example: 1, 1, 2, 3, 5...";
        }
        else
        {
            this.currentMsg = -1;
            this.hinterPanel.SetActive(false);
        }
    }

    private void BitManipSet()
    {
        this.currentMsg++;
        if (currentMsg == 0)
        {
            this.textBoxOfHinter.text = "The toggles represent the bit representation of the given number.";
        }
        else if (currentMsg == 1)
        {
            this.textBoxOfHinter.text = "The rightmost is the least significant bit";
        }
        else
        {
            this.currentMsg = -1;
            this.hinterPanel.SetActive(false);
        }
    }

    private void ASCIIHintSet()
    {
        this.currentMsg++;
        if (currentMsg == 0)
        {
            this.textBoxOfHinter.text = "Consider searching for the standart encoding table.";
        }
        else if (currentMsg == 1)
        {
            this.textBoxOfHinter.text = "Have you found the ASCII table?";
        }
        else
        {
            this.currentMsg = -1;
            this.hinterPanel.SetActive(false);
        }
    }

    #endregion
}
