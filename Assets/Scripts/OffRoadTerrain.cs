using UnityEngine;

public class OffRoadTerrain : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision){
        if(collision.gameObject.CompareTag("Player"))
            Debug.Log("Get back on the road!");

    }

}
