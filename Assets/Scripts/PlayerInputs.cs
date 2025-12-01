using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputs : MonoBehaviour
{
    public Rigidbody sphereRB;
    public float bashPow = 4f; 

    public InputActionAsset inputActions;
    public InputAction leftBash;
    public InputAction rightBash;

    void Awake(){
        leftBash = inputActions.FindActionMap("Gameplay").FindAction("LeftBash");
        leftBash.performed += ONleftBash;

        rightBash = inputActions.FindActionMap("Gameplay").FindAction("RightBash");
        rightBash.performed += ONRightBash;
    }

    void OnEnable(){
        leftBash.Enable();
        rightBash.Enable();
    }

    void ONleftBash(InputAction.CallbackContext context){
        sphereRB.AddForce(transform.right * bashPow*1000, ForceMode.Impulse);
    }

    void ONRightBash(InputAction.CallbackContext context){
        sphereRB.AddForce(transform.right * -bashPow*1000, ForceMode.Impulse);
    }

}
