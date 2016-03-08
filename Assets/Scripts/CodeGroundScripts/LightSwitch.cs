using System;
using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class LightSwitch : MonoBehaviour
{
    private Light[] lights;
    private Color[] colors;
    private bool isPlaying;
    public AudioClip[] songs;

    // Use this for initialization
    void Start()
    {
        this.lights = this.GetComponentsInChildren<Light>();
        this.colors = new[]
        {Color.blue, Color.cyan, Color.green, Color.magenta, Color.red, Color.white, Color.yellow, Color.black};
    }

    // Update is called once per frame
    void Update()
    {
        float value = 0;
        var info = AudioListener.GetOutputData(14, 0);

        foreach (var infoM in info)
        {
            value += Math.Abs(infoM);
        }


        if (this.isPlaying && value > 0.5f && value <= 7f)
        {

            foreach (var light1 in this.lights)
            {
                light1.color = this.colors[(int)(value)];
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.isPlaying = true;
        }
        
    }
}
