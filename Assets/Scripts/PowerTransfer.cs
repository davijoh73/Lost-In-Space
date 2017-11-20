using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerTransfer : MonoBehaviour {

    public GameObject timerHud, buttonObj, firstScreen, secondScreen;
    public Material buttonLit, buttonDark;
    Material[] buttonMats;
    public GvrAudioSource soundSource;
    public AudioClip buttonPressSound;

    // Use this for initialization
    void Start () {
        buttonMats = buttonObj.GetComponent<Renderer>().materials;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ButtonPress()
    {
        //Add two minutes to the game countdown timer
        timerHud.GetComponent<CountdownTimer>().AddTime(120f);

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
