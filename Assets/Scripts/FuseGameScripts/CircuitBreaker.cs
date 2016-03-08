using UnityEngine;
using System.Collections;

public class CircuitBreaker : MonoBehaviour
{

    public Animation Animation;
    public int index;
    public bool isOn;

    void Start()
    {
        int startState = Random.Range(0, 2);

        if (startState == 1)
        {
            this.isOn = true;
        }
        else
        {
            this.isOn = false;
        }

        PlayAnimation();
        this.isOn = !this.isOn;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    public void ChangeState()
    {
        if (!this.Animation.isPlaying && !this.Animation.IsPlaying("TurnOn") && !this.Animation.IsPlaying("TurnOff"))
        {
            PlayAnimation();
            this.isOn = !this.isOn;
        }
    }

    public void PlayAnimation()
    {
        this.Animation.Play(this.isOn ? "TurnOff" : "TurnOn");
    }
}
