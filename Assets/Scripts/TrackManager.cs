using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class TrackManager : MonoBehaviour
{
    //spawn players in starting positions
    //spawn 2 players if myltiplayer 
    //start a countdown, block playerinput before countdown
    //start test track timer
    //go to win podium

    public GameObject player;
    public Transform spawnPoint;
    //public GameObject pauseMenu;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //pauseManu.SetActive(false);

        if(MainMenu.playerNum <= 1)
            //SpawnPlayers();

        if(MainMenu.playerNum >=2)
            SpawnPlayers();
            SpawnPlayers();

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPlayers(){    //spawn one player
        Instantiate(player, spawnPoint.position, spawnPoint.rotation);

    }

    public void EndGame(){
        //display a win podium with the player's time
    }

}
