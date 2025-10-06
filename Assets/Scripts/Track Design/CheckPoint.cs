using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public bool check = false;

    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Player")){
            check = true;
        }
    }

    public void SetFalse(){
        check = false;
    }
}
