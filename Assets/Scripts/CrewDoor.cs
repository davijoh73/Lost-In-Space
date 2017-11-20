using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrewDoor : MonoBehaviour 
{
    //The locked variable is used in the Unlock method to "unlock" the door
    public bool locked = false;
    //Trigger used to open the door once it's unlocked
    public bool openDoor = false;
    //Sound clips used for when the door is locked, and when it's opened
    public GvrAudioSource soundSource;
    public AudioClip doorLocked;
    public AudioClip doorOpen;

    //Sections of the door that need to open together
    public GameObject rightSide, leftSide;

    void Update() {
        //If door is unlocked and not fully raised, continue raising door
        if (openDoor && leftSide.transform.position.x < 0.7154884f)
        {
            rightSide.transform.Translate(0, 0, 0.5f * Time.deltaTime, Space.World);
            leftSide.transform.Translate(0, 0, -0.5f * Time.deltaTime, Space.World);
        }
    }

    public void OnDoorClicked() {
        if (locked == false)
        {
            //Trigger the door to open via animation script and play opening door sound
            openDoor = true;
            soundSource.clip = doorOpen;
            soundSource.Play();
        }
        else
        {
            //Play locked door audio clip
            soundSource.clip = doorLocked;
            soundSource.Play();
        }
    }

    public void Unlock()
    {
        //Call this method to unlock the door
        locked = false;
    }
}
