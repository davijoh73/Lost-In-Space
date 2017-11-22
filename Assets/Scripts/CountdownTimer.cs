using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public int Minutes = 10;
    public int Seconds = 0;

    private Text m_text;
    private bool Timer = true;
    public static float m_leftTime;

    private void Awake()
    {
        m_text = GetComponent<Text>();
        m_leftTime = GetInitialTime();
    }

    private void Update()
    {
        if (m_leftTime > 0f)
        {
            //  Update countdown clock
            m_leftTime -= Time.deltaTime;
            Minutes = GetLeftMinutes();
            Seconds = GetLeftSeconds();

            //  Show current clock
            if (m_leftTime > 0f)
            {
                m_text.text = "Time : " + Minutes + ":" + Seconds.ToString("00");
            }
            else
            {
                //  The countdown clock has finished
                m_text.text = "Time : 0:00";
            }
        }
    }

    private float GetInitialTime()
    {
        return Minutes * 60f + Seconds;
    }

    private int GetLeftMinutes()
    {
        return Mathf.FloorToInt(m_leftTime / 60f);
    }

    private int GetLeftSeconds()
    {
        return Mathf.FloorToInt(m_leftTime % 60f);
    }

    public void AddTime(float extraTime)
    {
        m_leftTime += extraTime;
    }

    public void StopTimer()
    {
        Timer = false;
    }
}
