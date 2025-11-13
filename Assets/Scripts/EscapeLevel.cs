using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeLevel : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("escape")){
            //pauseManu.ShowPauseScreen();
            //Application.Quit();
            SceneManager.LoadScene("MainMenu");
        }
        
    }
}
