using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TMP_Text menuText;
    public TMP_Text playerSelect;

    public string singlePScene; //singleplayer scene
    public string multiPScene;  //multiplayer scene
    public string controlScene; //control menu

    public GameObject singleBut;
    public GameObject multiBut;
    public GameObject menuBut;
    public GameObject backBut;

    public GameObject twoP;
    public GameObject threeP;
    public GameObject fourP;

    int playerNum;


    public void Start(){
        ShowButtons();
        //menuText = gameObject.GetComponent<TMP_Text>();

        menuText.text = "beautiful menu";
        playerSelect.text = " ";
        backBut.SetActive(false);
        HideOther();

    }

    public void SingleStart(){
        playerNum = 1;
        SceneManager.LoadScene(singlePScene);
        
    }

    public void MultiStart(){       //load buttons to select numer of players (2-4);
        //SceneManager.LoadScene(multiPScene);
        playerSelect.text = "How many Players?";
        menuText.text = " ";
        HideButtons();
        ShowOther();
        backBut.SetActive(true);

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
        HideOther();
        menuText.text = "beautiful menu";
        playerSelect.text = " ";
        backBut.SetActive(false);
    }

    public void TWOplayer(){
        playerNum = 2;
    }
    public void THREEplayer(){
        playerNum = 3;
    }
    public void FOURplayer(){
        playerNum = 4;
    }

    void HideButtons(){
        singleBut.SetActive(false);
        multiBut.SetActive(false);
        menuBut.SetActive(false);
    }

    void HideOther(){
        twoP.SetActive(false);
        threeP.SetActive(false);
        fourP.SetActive(false);
    }

    void ShowButtons(){
        singleBut.SetActive(true);
        multiBut.SetActive(true);
        menuBut.SetActive(true);
    }

    void ShowOther(){
        twoP.SetActive(true);
        threeP.SetActive(true);
        fourP.SetActive(true);
    }
}
