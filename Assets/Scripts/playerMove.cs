using UnityEngine;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class playerMove : MonoBehaviour
{
    public Rigidbody sphereRB;

    public float forwardMove = 8f, reverseMove = 4f, maxSpeed = 50f, turnStr = 180f;
    // Start is called once before the first execution oated

    private float speedInput, turnInput;

    public float bashPow = 20f; 

    public InputActionReference move;

    private Vector3 m_moveDirction; 

    void OnEnable(){ //everytime the object is set active
        //attack.action.performed += weaponManager.use;
    }

    void OnDisable(){

    }

    //void Attack(Input)


    void Start()
    {
        sphereRB.transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        //UpdateInput();

        speedInput = 0f;
        if (Input.GetAxis("Vertical") > 0)
        {
            speedInput = Input.GetAxis("Vertical") * forwardMove * 1000;
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            speedInput = Input.GetAxis("Vertical") * reverseMove * 1000;
        }

        turnInput = Input.GetAxis("Horizontal");
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, turnInput * turnStr * Time.deltaTime, 0f));

        //transform.position = sphereRB.transform.position; //move to the shpere rb

        if (Input.GetMouseButtonDown(0)){     //LEFT CLICK  Input.GetMouseButtonDown(0)
            //Debug.Log("Pressed left-click.");

            sphereRB.AddForce(transform.right * -bashPow*1000, ForceMode.Impulse);
        }
            
        if (Input.GetMouseButtonDown(1)){    //RIGHT CLICK
            //Debug.Log("Pressed right-click.");
            
            sphereRB.AddForce(transform.right * bashPow*1000, ForceMode.Impulse);
        }

        if(sphereRB.position.y > 1){        //add gravity so player falls off ramps better
            sphereRB.AddForce(Physics.gravity * 200);
            //Physics.gravity
        }

        transform.position = sphereRB.transform.position; //move to the shpere rb
        
    }

    private void FixedUpdate()
    {
        //sphereRB.AddForce(transform.forward * forwardMove * 1000);
        if (Mathf.Abs(speedInput) > 0)
        {
            sphereRB.AddForce(transform.forward * speedInput);
        }

    }

    // void UpdateInput(){
    //     m_moveDirction = move.action.ReadValue<Vector3>();
    // }

}
