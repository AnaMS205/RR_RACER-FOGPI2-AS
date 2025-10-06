using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class TestTrackLapTimes : MonoBehaviour
{
    public TMP_Text lapTimesText;
    public float lapOne, lapTwo, lapThree;
    public Timer timer;

    void Start(){
        lapTimesText.text = " ";
    }

    public void LapOne(){
        lapOne = timer.time;
        lapTimesText.text = "Lap 1 :: " + lapOne.ToString("F2");
    }
    public void LapTwo(){
        lapTwo = timer.time;
        lapTimesText.text = "Lap 1 :: " + lapOne.ToString("F2") +"\nLap 2 :: " +lapTwo.ToString("F2");
    }
    public void LapThree(){
        lapThree = timer.time;
        lapTimesText.text = "Lap 1 :: " + lapOne.ToString("F2") +"\nLap 2 :: " + lapTwo.ToString("F2") + "\nLap 3 :: " +lapThree.ToString("F2");
    }
}
