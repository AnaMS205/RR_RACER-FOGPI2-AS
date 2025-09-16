using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TMP_Text menuText;

    public string singlePScene; //singleplayer scene
    public string multiPScene;  //multiplayer scene
    public string controlScene; //control menu

    public GameObject singleBut;
    public GameObject multiBut;
    public GameObject menuBut;
    public GameObject backBut;


    public void Start(){
        ShowButtons();
        //menuText = gameObject.GetComponent<TMP_Text>();

        menuText.text = "beautiful menu";
        backBut.SetActive(false);

    }

    public void SingleStart(){
        SceneManager.LoadScene(singlePScene);
    }

    public void multiStart(){
        SceneManager.LoadScene(multiPScene);
    }

    public void LoadMenu(){
        //SceneManager.LoadScene(controlScene);
        HideButtons();
        menuText.text = "W/A/S/D = To Drive\n Left and Right mouse buttons = Bash Left and Right";
        backBut.SetActive(true);
    }

    public void OuitGame(){
        Application.Quit();     //quit game
    }

    public void BackButton(){
        ShowButtons();
        menuText.text = "beautiful menu";
        backBut.SetActive(false);
    }

    void HideButtons(){
        singleBut.SetActive(false);
        multiBut.SetActive(false);
        menuBut.SetActive(false);
    }

    void ShowButtons(){
        singleBut.SetActive(true);
        multiBut.SetActive(true);
        menuBut.SetActive(true);
    }
}
