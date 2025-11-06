using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Timer : MonoBehaviour
{
    private TMP_Text timerText;
    public float time;
    public bool running = false;
    //public int sec;
    //float recordTime;

    void Start()
    {
        timerText = gameObject.GetComponent<TMP_Text>();
        timerText.text ="You should race THREE laps on the testing track"; //keep screen blank
    }

    void Update()
    {
        if (running) // == true
        {
            time += Time.deltaTime;

            //int sec = (int)time;

            timerText.text = "Time: " +time.ToString("F2");
        }
        
    }

    public void StartTime(){
        running = true;
    }

    public void StopTime()  //timer.StopTime(); to activate
    {
        running = false;
        //int times = (int)time;
        timerText.text = "You finished the race in " +time.ToString("F2")+ " seconds";

    }

    public void GetTime(){
        int currentTime = (int)time;
        //yield return currentTime;
        //return currentTime;
    }
}
