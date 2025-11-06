using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    //public InputActionAsset pauseInput;

    public GameObject pauseScreen;
    // public InputActionAsset inputActions;

    // public InputAction pauseInput;

    // void OnEnable(){
    //     inputActions.FindActionMap("Gameplay").Enable();
    // }
    // void OnDisable(){
    //     inputActions.FindActionMap("Gameplay").Disable();
    // }

    // void Awake(){
    //     pauseInput = InputSystem.actions.FindAction("Pause");
    // }

    bool showing;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HidePauseScreen();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (showing)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
        // if(showing == true){
        //     ShowPauseScreen();
        //     //Debug.Log("paused");
        //     Time.timeScale = 0f;
        // }
        // if(showing == false){
        //     Time.timeScale = 1f;
        //     HidePauseScreen();
        // }
        
    }

    public void PauseGame(){
        ShowPauseScreen();
        Time.timeScale = 0f;
        showing = true;
    }
    public void ResumeGame(){
        HidePauseScreen();
        Time.timeScale = 1f;
        showing = false;
    }

    public void BacktoMenu(){
        ResumeGame();
        SceneManager.LoadScene("MainMenu");
        //go back to the main menu
    }

    public void OuitGame(){
        Application.Quit();     //quit game
    }

    public void HidePauseScreen(){
        pauseScreen.SetActive(false);
    }

    public void ShowPauseScreen(){
        pauseScreen.SetActive(true);
    }
}
