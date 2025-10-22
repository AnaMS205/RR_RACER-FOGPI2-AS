using UnityEngine;

public class TrackManager : MonoBehaviour
{
    //spawn players in starting positions
    //spawn 2 players if myltiplayer 
    //start a countdown, block playerinput before countdown
    //start test track timer
    //go to win podium

    public GameObject players;
    public Transform spawnPoint;

    //public GameObject spawnBarriers;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPlayers();
        SpawnPlayers();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPlayers(){
        Instantiate(players, spawnPoint.position, spawnPoint.rotation);
    }

    // void MoveSpawnBarriers(){
    //     //spawnBarriers.Vector3.position = transfrom.position(spawnBarriers.x, -5, spawnBarriers.z);
    // }

    void StartCountDown(){

    }
}
