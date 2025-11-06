using UnityEngine;
using TMPro;


public class CountdownTimer : MonoBehaviour
{
    public float countDuration = 3f;
    public TMP_Text countdownText;

    float currentTime;
    bool isCounting = false;

    //public playerMove playerMovement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //GetComponent<PlayerInput>().DeactivateInput();
        // currentTime = countDuration;
        // isCounting = true;
        // UpdateCountdown();
        //playerMovement.DisableInput();

        //StartCountDown();
    }

    public void StartCountDown(){
        currentTime = countDuration;
        isCounting = true;
        UpdateCountdown();
    }

    // Update is called once per frame
    void Update()
    {
        if(isCounting){
            currentTime -= Time.deltaTime;

            if(currentTime <=-3){
                //currentTime = 0;
                isCounting = false;
                //playerMovement.EnableInput();
            }
            UpdateCountdown();
        }
        
    }

    void UpdateCountdown(){
        int seconds = Mathf.CeilToInt(currentTime);
        countdownText.text = seconds.ToString();

        if(currentTime <= 0){
            //GetComponent<PlayerInput>().ActivateInput();
            countdownText.text = "GO!";
        }
        if(currentTime <= -3){
            countdownText.text = "";
        }
    }
}
