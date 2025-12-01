using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.InputSystem;
using System.Collections;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseScreen;

    public InputActionAsset inputActions;
    public InputAction pauseInput;

    void Awake(){
        pauseInput = inputActions.FindActionMap("Gameplay").FindAction("Pause");
        pauseInput.performed += OnPausePerformed;
    }

    void OnEnable(){
        pauseInput.Enable();
    }
    void OnDisable(){
        //pauseInput.Disable();
    }

    

    public bool showing;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HidePauseScreen();
        
    }

    void OnPausePerformed(InputAction.CallbackContext context){
        //Debug.Log("Paused");

        if (showing)
        {
            ResumeGame();
            showing = false;
        }
        else
        {
            PauseGame();
            showing = true;
        }

    }

    public void PauseGame(){
        ShowPauseScreen();
        Time.timeScale = 0f;
        showing = true;
    }
    public void ResumeGame(){
        Time.timeScale = 1f;
        HidePauseScreen();
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
