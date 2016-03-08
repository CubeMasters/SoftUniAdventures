using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public int CurrentResult;
    public int RequiredVoltage;
    public Light RedLight;
    public Light GreenLight;
    public Text textbox;


    private bool isFinished = false;

    private float time = 1.1f;

    void Start()
    {
        Screen.orientation = ScreenOrientation.Landscape;

        this.RequiredVoltage = Random.Range(0, 256);
        this.textbox.text = string.Format("{0}", this.RequiredVoltage);
    }


    void FixedUpdate()
    {
        GameObject[] curcuitBreakers = GameObject.FindGameObjectsWithTag("CircuitBreaker");
        this.CurrentResult = 0;

        foreach (var curcuitBreaker in curcuitBreakers)
        {
            var script = curcuitBreaker.GetComponent<CircuitBreaker>();

            if (script.isOn)
            {
                this.CurrentResult += (int)Mathf.Pow(2, script.index);
            }
        }
    }

    void LateUpdate()
    {
        if (this.CurrentResult == this.RequiredVoltage)
        {
            this.isFinished = true;
        }
        if (this.isFinished)
        {
            this.RedLight.enabled = false;
            this.GreenLight.enabled = true;
            this.textbox.text = "Win";
            this.time -= Time.deltaTime;
            if (this.time <= 0)
            {
                GameMaster.GamesCompleted++;
                SceneManager.LoadScene("CodeGround", LoadSceneMode.Single);
            }



        }

    }
}
