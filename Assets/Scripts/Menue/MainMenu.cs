using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using TMPro;


public class MainMenu : MonoBehaviour
{
    public TMP_Text menuText;
    public TMP_Text playerSelect;

    public string singlePScene; //singleplayer scene
    public string multiRace;  //multiplayer scene
    public string multiFreeplay;
    public string tutorialTrack; //tutorial menu

    public GameObject menumenu;
    public GameObject multipMenu;
    public GameObject howToPlay;

    // public GameObject singleBut;
    // public GameObject multiBut;
    // public GameObject menuBut;
    // public GameObject TutBut;
    public GameObject backBut;

    public static int playerNum = 0;

    public void Start(){
        ShowButtons();
        multipMenu.SetActive(false);
        howToPlay.SetActive(false);
        //menuText = gameObject.GetComponent<TMP_Text>();

        //playerSelect.text = " ";
        backBut.SetActive(false);
        //HideOther();

    }

    public void TutorialTrack(){
        playerNum = 1;
        SceneManager.LoadScene(tutorialTrack);
        //load tutorial track
    }

    public void SingleStart(){
        playerNum = 1;
        SceneManager.LoadScene(singlePScene);
        
    }

    public void MultiStart(){       //load buttons to select numer of players (2-4);

        multipMenu.SetActive(true);
        HideButtons();
        backBut.SetActive(true);

        //TwoPlayer();

    }

    ///////////// Multiplayer select buttons
    public void MultiTrack(){
        playerNum = 2;

        SceneManager.LoadScene(multiRace);
    }
    public void MultiFree(){
        playerNum = 2;

        SceneManager.LoadScene(multiFreeplay);
    }

    public void LoadMenu(){
        HideButtons();
        howToPlay.SetActive(true);

        backBut.SetActive(true);
    }

    public void OuitGame(){
        Application.Quit();     //quit game
    }

    public void BackButton(){
        ShowButtons();
        //HideOther();
        //playerSelect.text = " ";
        backBut.SetActive(false);
        multipMenu.SetActive(false);
        howToPlay.SetActive(false);
    }


    void HideButtons(){
        menumenu.SetActive(false);
        // multiBut.SetActive(false);
        // menuBut.SetActive(false);
        // TutBut.SetActive(false);
    }


    void ShowButtons(){
        menumenu.SetActive(true);
        // multiBut.SetActive(true);
        // menuBut.SetActive(true);
        // TutBut.SetActive(true);
    }


}
