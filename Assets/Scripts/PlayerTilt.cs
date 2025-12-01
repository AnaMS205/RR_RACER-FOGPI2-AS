using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerTilt : MonoBehaviour
{
    public float turnSTR = 120f;
    float turnInput;

    public InputActionAsset InputAction;
    private Vector2 moveDirection;

    public void OnMove(InputValue input){
        moveDirection = input.Get<Vector2>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        turnInput = moveDirection.x;
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, turnInput * turnSTR * Time.deltaTime, 0f));
        
    }
}
