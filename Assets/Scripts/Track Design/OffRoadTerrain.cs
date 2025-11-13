using UnityEngine;

public class OffRoadTerrain : MonoBehaviour
{
    //public playerMove player;

    public float slowdown;  //slowdown should be < 1
    //make sure the normal speed is the inveres of the slowdown
    //normalSpeed = 1f/slowdown;

    void OnTriggerEnter(Collider other){
        //Debug.Log("Get back on the road!");
        if(other.gameObject.CompareTag("Player"))
            //Debug.Log("Get back on the road!");
            playerMove.forwardMove *= slowdown;
            playerMove.reverseMove *= slowdown;
            playerMove.turnStr *= slowdown;

    }

    void OnTriggerExit(Collider other){
        if(other.gameObject.CompareTag("Player"))
            //Debug.Log("Get back on the road!");
            playerMove.forwardMove *= 1/slowdown;
            playerMove.reverseMove *= 1/slowdown;
            playerMove.turnStr *= 1/slowdown;

    }

}
