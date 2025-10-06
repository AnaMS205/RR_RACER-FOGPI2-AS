using UnityEngine;

public class OffRoadTerrain : MonoBehaviour
{
    public playerMove player;

    public float slowdown;
    //make sure the normal speed is the inveres of the slowdown
    //normalSpeed = 1f/slowdown;

    void OnTriggerEnter(Collider other){
        //Debug.Log("Get back on the road!");
        if(other.gameObject.CompareTag("Player"))
            Debug.Log("Get back on the road!");
            player.forwardMove *= slowdown;
            player.reverseMove *= slowdown;
            player.turnStr *= slowdown;

    }

    void OnTriggerExit(Collider other){
        if(other.gameObject.CompareTag("Player"))
            //Debug.Log("Get back on the road!");
            player.forwardMove *= 1/slowdown;
            player.reverseMove *= 1/slowdown;
            player.turnStr *= 1/slowdown;

    }

}
