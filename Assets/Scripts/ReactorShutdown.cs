using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactorShutdown : MonoBehaviour {

    public GameObject bridgeTimer1, buttonObj, firstScreen, secondScreen;
    public Material buttonLit, buttonDark;
    Material[] buttonMats;
    public GvrAudioSource soundSource;
    public AudioClip buttonPressSound;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ButtonPress()
    {
        //Add two minutes to each of the countdown timers
        bridgeTimer1.GetComponent<CountdownTimer>().StopTimer();

        //Play button press sound
        soundSource.clip = buttonPressSound;
        soundSource.Play();

        //Change material of the buttons to acknowledge interaction
        buttonMats[1] = buttonDark;
        buttonMats[0] = buttonLit;
        buttonObj.GetComponent<Renderer>().materials = buttonMats;

        //Change the screen to indicate that power was successfully transfered
        firstScreen.SetActive(false);
        secondScreen.SetActive(true);
    }
}
