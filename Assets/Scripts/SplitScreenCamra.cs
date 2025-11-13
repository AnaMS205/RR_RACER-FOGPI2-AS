using UnityEngine;
using System;
using UnityEngine.InputSystem; 


[RequireComponent(typeof(Camera))]
public class SplitScreenCamra : MonoBehaviour
{
    public Camera cam;
    int index;
    int totalPlayers;

    private void HandlePlayerJoined(PlayerInput obj){
        totalPlayers = PlayerInput.all.Count;
        SetupCamera();
    }

    private void SetupCamera(){
        if(totalPlayers == 1){
            cam.rect = new Rect(0,0,1,1);   //full screen for one player
        }else if(totalPlayers == 2){
            cam.rect = new Rect(index == 0? 0 :0.5f,0,0.5f, 1);  //split screen for two players
        }else if(totalPlayers == 3){    //cominsate for 3 or 4 players    compenstate? compensate? compenset?
            cam.rect = new Rect(index == 0 ? 0 : (index == 1 ? 0.5f : 0), index < 2? 0.5f :0, index < 2? 0.5f :1, 0.5f );
        }else{
            cam.rect = new Rect((index %2) * 0.5f, (index<2) ? 0.5f : 0f,0.5f,0.5f ); 
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
  
        index = GetComponentInParent<PlayerInput>().playerIndex;
        totalPlayers = PlayerInput.all.Count;
        cam = GetComponent<Camera>();
        cam.depth = index;

        SetupCamera();
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerInputManager.instance != null)
            PlayerInputManager.instance.onPlayerJoined += HandlePlayerJoined;
        
    }
}
