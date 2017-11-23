using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerUpdate : MonoBehaviour {

    private Text m_text;
    public int Minutes;
    public int Seconds;
    public GameObject mainTimer;

    // Use this for initialization
    void Start () {
        m_text = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        Minutes = mainTimer.GetComponent<CountdownTimer>().GetLeftMinutes();
        Seconds = mainTimer.GetComponent<CountdownTimer>().GetLeftSeconds();
        m_text.text = "Time to reactor failure : " + Minutes + ":" + Seconds.ToString("00");
    }
}
