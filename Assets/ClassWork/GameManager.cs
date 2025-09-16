using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static GameManager instance{ get; private set; } //getter and setter
    public bool isPlaying = true; //put an if statement

    //public Player player;
    //public List<Tank> enemies;

    void Awake(){
        if(instance == null){
            instance = this;
                //optional
            //DontDystroyOnLoad(gameObject);
        }else{
                //awake
            //instance.NewScene();
            Destroy(this);
            return;

        }
    }
}
