using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenKey : MonoBehaviour 
{
    //Create a reference to the Door
    public GameObject theDoor;
    public static bool keyCollected = false;

    void Update()
	{

	}

	public void OnKeyClicked()
	{
        // Call the Unlock() method on the Door
        theDoor.GetComponent<GreenDoor>().Unlock();
        // Set the Key Collected Variable to true
        keyCollected = true;
        // Destroy the key. Check the Unity documentation on how to use Destroy
        Destroy(gameObject, 0.2f);
    }

}
