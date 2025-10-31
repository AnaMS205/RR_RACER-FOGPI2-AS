using UnityEngine;

public class TrackManager : MonoBehaviour
{
    //spawn players in starting positions
    //spawn 2 players if myltiplayer 
    //start a countdown, block playerinput before countdown
    //start test track timer
    //go to win podium

    public GameObject player;
    public Transform spawnPoint;

    //public GameObject spawnBarriers;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(MainMenu.playerNum <= 1)
            SpawnPlayers();

        if(MainMenu.playerNum >=2)
            SpawnPlayers();
            SpawnPlayers();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("escape")){
            Application.Quit();
        }
        
    }

    void SpawnPlayers(){    //spwan one player
        Instantiate(player, spawnPoint.position, spawnPoint.rotation);
    }

}
