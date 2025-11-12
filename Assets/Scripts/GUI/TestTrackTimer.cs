using UnityEngine;
using TMPro;

public class TestTrackTimer : MonoBehaviour
{
    public TestTrackLapTimes lapTime;
    public Timer timer;
    public CheckPoint checkPoint;

    public WinScreen winScreen;

    private int laps = 0;

 

    //checkPoint.check = false;

    void Start(){
        laps = 0;
    }

    void OnTriggerEnter(Collider other){
        //Debug.Log("Start the race");
        if(other.gameObject.CompareTag("Player") && laps == 0 ){
            //Debug.Log("Start the race");
            //start and display timer 
            timer.StartTime();
            checkPoint.SetFalse();
            laps ++;

        }
        if(other.gameObject.CompareTag("Player") && laps == 1 && checkPoint.check == true){
            
            //lapTimesText.text = "Lap 1 ::" + lapOne.ToString();
            lapTime.LapOne();
            checkPoint.SetFalse();
            laps ++;
        }
        if(other.gameObject.CompareTag("Player") && laps == 2 && checkPoint.check == true){
    
            //lapTimesText.text = "Lap 1 ::" + lapOne.ToString() +"\nLap 2 ::" +lapTwo.ToString();
            lapTime.LapTwo();
            checkPoint.SetFalse();
            laps ++;
        }
        if(other.gameObject.CompareTag("Player") && laps == 3 && checkPoint.check == true){
        
            //lapTimesText.text = "Lap 1 ::" + lapOne.ToString() +"\nLap 2 ::" + lapTwo.ToString() + "\nLap 3 ::" +lapThree.ToString();
            lapTime.LapThree();
            checkPoint.SetFalse();
            timer.StopTime();
            laps = 0;

            winScreen.ShowWinScreen();
        }
            
    }
}
