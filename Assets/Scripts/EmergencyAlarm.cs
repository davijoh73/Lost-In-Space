using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmergencyAlarm : MonoBehaviour {

    public GameObject eLight1, eLight2, bridgeLight1, bridgeLight2, bridgeLight3, bridgeLight4;
    
    // Use this for initialization
	void Start () {

        //Start audio for alarm Klaxons
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ResetAlarm()
    {
        //Stop alarm audio
        eLight1.SetActive(false);
        eLight2.SetActive(false);
        bridgeLight1.SetActive(true);
        bridgeLight2.SetActive(true);
        bridgeLight3.SetActive(true);
        bridgeLight4.SetActive(true);
        //change materials for each light to match new state
    }
}
