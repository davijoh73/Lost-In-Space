using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class CountdownTimer : MonoBehaviour
{
    public int Minutes = 0;
    public int Seconds = 0;

    private Text m_text;
    private bool Timer = true;
    public static float m_leftTime;

    NavMeshAgent agent;

    private void Awake()
    {
        m_text = GetComponent<Text>();
        m_leftTime = GetInitialTime();
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (m_leftTime > 0f)
        {
            if (Timer)
            {
                //  Update countdown clock
                m_leftTime -= Time.deltaTime;
                Minutes = GetLeftMinutes();
                Seconds = GetLeftSeconds();
            }

            //  Show current clock
            /*if (m_leftTime > 0f)
            {
                m_text.text = "Time to reactor failure : " + Minutes + ":" + Seconds.ToString("00");
            }
            else
            {
                //  The countdown clock has finished
                m_text.text = "Uh oh!!";
            }*/
        }
        else
        {
            //Stop navmesh agent and display game over splash screen with option to restart or exit
            agent.isStopped = true;
            m_leftTime = 0;

        }
    }

    private float GetInitialTime()
    {
        return Minutes * 60f + Seconds;
    }

    public int GetLeftMinutes()
    {
        return Mathf.FloorToInt(m_leftTime / 60f);
    }

    public int GetLeftSeconds()
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
