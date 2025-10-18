using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    //public InputActionAsset pauseInput;

    public GameObject pauseScreen;
    public InputActionAsset inputActions;

    public InputAction pauseInput;

    void OnEnable(){
        inputActions.FindActionMap("Gameplay").Enable();
    }
    void OnDisable(){
        inputActions.FindActionMap("Gameplay").Disable();
    }

    void Awake(){
        pauseInput = InputSystem.actions.FindAction("Pause");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HidePauseScreen();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pauseInput.IsPressed()){
            Debug.Log("paused");
            ShowPauseScreen();
        }
        
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
