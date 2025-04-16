using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;

    public TMP_Text TimerText;

    // Start is called before the first frame update
    void Start()
    {
        TimerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerOn)
        {
            if (TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
            }
            else
            {
                TimeLeft = 0;
                timesUp();
            }
        }
    }

    public void stopTimer()
    {
        TimerOn = false;
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;
        TimerText.text = "Time until caught: " + Mathf.FloorToInt(currentTime);
    }

    void timesUp()
    {
        TimerText.text = "Time's Up!";
    }
}
