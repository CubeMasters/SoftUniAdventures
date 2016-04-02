using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class MainCameraScript : MonoBehaviour {

    // Use this for initialization
    public GameObject hinterPanel;
    public HintsGiverScript hintsGiver;

    private Camera mainCamera;

    void Start ()
    {
        hinterPanel.SetActive(true);
        hintsGiver.SetWantedAdviceSet(AdviceSets.FirstStartOfGameSet);
        this.mainCamera = this.GetComponent<Camera>();  
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
