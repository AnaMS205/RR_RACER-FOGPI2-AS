using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using TMPro;


public class MainMenu : MonoBehaviour
{
    public TMP_Text menuText;
    public TMP_Text playerSelect;

    public string singlePScene; //singleplayer scene
    public string multiPScene;  //multiplayer scene
    public string controlScene; //control menu

    public GameObject multipMenu;

    public GameObject singleBut;
    public GameObject multiBut;
    public GameObject menuBut;
    public GameObject TutBut;
    public GameObject backBut;

    public static int playerNum = 0;

    public void Start(){
        ShowButtons();
        multipMenu.SetActive(false);
        //menuText = gameObject.GetComponent<TMP_Text>();

        menuText.text = "beautiful menu";
        playerSelect.text = " ";
        backBut.SetActive(false);
        //HideOther();

    }

    public void TutorialTrack(){
        playerNum = 1;
        //load tutorial track
    }

    public void SingleStart(){
        playerNum = 1;
        SceneManager.LoadScene(singlePScene);
        
    }

    public void MultiStart(){       //load buttons to select numer of players (2-4);

        // multipMenu.SetActive(true);
        // HideButtons();
        // backBut.SetActive(true);

        TwoPlayer();

    }

    ///////////// Multiplayer select buttons
    public void TwoPlayer(){
        playerNum = 2;

        SceneManager.LoadScene(multiPScene);
    }
    public void ThreePlayer(){
        playerNum = 3;

        SceneManager.LoadScene(multiPScene);
    }
    public void FourPlayer(){
        playerNum = 4;

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
        //HideOther();
        menuText.text = "beautiful menu";
        playerSelect.text = " ";
        backBut.SetActive(false);
    }


    void HideButtons(){
        singleBut.SetActive(false);
        multiBut.SetActive(false);
        menuBut.SetActive(false);
        TutBut.SetActive(false);
    }


    void ShowButtons(){
        singleBut.SetActive(true);
        multiBut.SetActive(true);
        menuBut.SetActive(true);
        TutBut.SetActive(true);
    }


}
