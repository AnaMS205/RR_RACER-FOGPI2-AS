using UnityEngine;

public class TestTrackTimer : MonoBehaviour
{
    public Timer timer;
    private int laps = 0;

    void OnTriggerEnter(Collider other){
        //Debug.Log("Start the race");
        if(other.gameObject.CompareTag("Player") && laps == 0){
            //Debug.Log("Start the race");
            //start and display timer 
            timer.StartTime();
            laps ++;

        }
        if(other.gameObject.CompareTag("Player") && laps == 1){
            timer.StopTime();
            laps = 0;
        }
            
    }
}
