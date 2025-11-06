using UnityEngine;

public class WinScreen : MonoBehaviour
{
    public GameObject winScreen;
    public Timer timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        winScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer.running == false){
            ShowWinScreen();
        }
        
    }

    public void ShowWinScreen(){
        winScreen.SetActive(false);
    }

    void BGTween(){

    }
}
