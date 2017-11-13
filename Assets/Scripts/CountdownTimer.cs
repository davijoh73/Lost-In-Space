using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour {

    float totalTime = 600f; //10 minutes
    private object timer;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        totalTime -= Time.deltaTime;
        UpdateLevelTimer(totalTime);
    }

    public void UpdateLevelTimer(float totalSeconds)
    {
        int minutes = Mathf.FloorToInt(totalSeconds / 60f);
        int seconds = Mathf.RoundToInt(totalSeconds % 60f);

        string formatedSeconds = seconds.ToString();

        if (seconds == 60)
        {
            seconds = 0;
            minutes += 1;
        }

        //timer.text = minutes.ToString("00") + ":" + seconds.ToString("00");
        GameObject.Find("Timer").GetComponent<Text>().text = formatedSeconds;
    }
}
