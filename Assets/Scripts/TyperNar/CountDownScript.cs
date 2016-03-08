using System;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountDownScript : MonoBehaviour
{
    public GameObject result;
    public GameObject backwardsBtn;
    public GameObject replayBtn;
    public GameObject expectedInput;
    public GameObject actualInput;
                                 
    private Text resultText;
    private Text timerText;
    private float timer;

    private bool hasGameFinished;
                                     
    void Start()
    {
        timer = 60;
        this.timerText = this.GetComponent<Text>();     
        this.timerText.text = timer.ToString("f2");

        this.resultText = this.result.GetComponent<Text>();
        this.hasGameFinished = false;
    }
                                      
    void Update()
    {
        if (!hasGameFinished)
        {
            if (timer <= 0.0f)
            {
                this.timer = 0.0f;
                this.result.SetActive(true);
                this.resultText.text = string.Format("You wrote {0} words. Nice one!", WordChecker.counter.ToString());
                                                                       
                actualInput.SetActive(false);
                expectedInput.SetActive(false);

                replayBtn.SetActive(true);
                backwardsBtn.SetActive(true);
                this.timerText.text = timer.ToString("f2");

                this.hasGameFinished = true;

                SceneManager.LoadScene("CodeGround");
            }
            else
            {
                timer -= Time.deltaTime;
                this.timerText.text = timer.ToString("f2");
            }
        }     
    }

    public float GetTimer()
    {
        return this.timer;
    }
}
