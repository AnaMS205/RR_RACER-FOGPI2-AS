using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using TMPro;
using System.Collections; //corutine


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

    public void TTTrack(){
        StartCoroutine(TutorialTrack());
    }
    IEnumerator TutorialTrack(){
        yield return new WaitForSeconds(0.6f);
        playerNum = 1;
        SceneManager.LoadScene(tutorialTrack);
        //load tutorial track
    }

    public void SinglePLayerStart(){
        StartCoroutine(SingleStart());
    }
    IEnumerator SingleStart(){
        yield return new WaitForSeconds(0.6f);
        playerNum = 1;
        SceneManager.LoadScene(singlePScene);
        
    }

    public void MultiPLayerMenu(){
        StartCoroutine(MultiStart());
    }
    IEnumerator MultiStart(){       //load buttons to select numer of players (2-4);
        yield return new WaitForSeconds(0.6f);

        multipMenu.SetActive(true);
        HideButtons();
        backBut.SetActive(true);

        //TwoPlayer();

    }

    ///////////// Multiplayer select buttons
    public void MultiPLayerRace(){
        StartCoroutine(MultiTrack());
    }
    IEnumerator MultiTrack(){
        yield return new WaitForSeconds(0.6f);
        playerNum = 2;

        SceneManager.LoadScene(multiRace);
    }
    public void MultiPLayerFree(){
        StartCoroutine(MultiFree());
    }
    IEnumerator MultiFree(){
        yield return new WaitForSeconds(0.6f);
        playerNum = 2;

        SceneManager.LoadScene(multiFreeplay);
    }

    public void SubMenuLoad(){
        StartCoroutine(LoadMenu());
    }
    IEnumerator LoadMenu(){
        yield return new WaitForSeconds(0.6f);
        HideButtons();
        howToPlay.SetActive(true);

        backBut.SetActive(true);
    }

    public void OuitGame(){
        Application.Quit();     //quit game
    }

    public void BackButton(){
        ShowButtons();
   
        backBut.SetActive(false);
        multipMenu.SetActive(false);
        howToPlay.SetActive(false);
    }


    void HideButtons(){
        menumenu.SetActive(false);
    }

    void ShowButtons(){
        menumenu.SetActive(true);
    }

}
