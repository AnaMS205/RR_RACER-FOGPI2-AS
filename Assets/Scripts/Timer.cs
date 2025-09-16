using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Timer : MonoBehaviour
{
    private TMP_Text timerText;
    private float time;
    private bool running = false;
    int sec;
    float recordTime;

    void Start()
    {
        timerText = gameObject.GetComponent<TMP_Text>();
        timerText.text =""; //keep screen blank
    }

    void Update()
    {
        if (running) // == true
        {
            time += Time.deltaTime;

            int sec = (int)time;

            timerText.text = "Time: " +sec.ToString();
        }
        
    }

    public void StartTime(){
        running = true;
    }

    public void StopTime()  //timer.StopTime(); to activate
    {
        if(time > recordTime){
            running = false;
            int times = (int)time;
            timerText.text = "You finished in " +times.ToString()+ " seconds";
        }
        // if(time < recordTime){
        //     running = false;
        //     int times = (int)time;
        //     timerText.text = "New Record," +times.ToString()+ " seconds!";
        //     recordTime += time;
            
        // }

        
    }
}
