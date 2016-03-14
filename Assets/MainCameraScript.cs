using UnityEngine;
using System.Collections;

public class MainCameraScript : MonoBehaviour {

    // Use this for initialization
    public GameObject hinterPanel;
    public HintsGiverScript hintsGiver;

    private Camera mainCamera;

    void Start ()
    {
        hinterPanel.SetActive(true);
        hintsGiver.SetWantedAdviceSet("InitialAdviceSet");
        this.mainCamera = this.GetComponent<Camera>();
        //this.mainCamera.farClipPlane = 12;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
