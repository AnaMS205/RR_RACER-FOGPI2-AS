using UnityEngine;
using System.Collections.Generic;
using UnityEngine.InputSystem;
//public Animation graph;
public class playerMove : MonoBehaviour
{

    //[SerializeFeild]

    public Rigidbody sphereRB;

    public float forwardMove = 8f, reverseMove = 4f, turnStr = 180f, maxSpeed;
    // Start is called once before the first execution oated 

    private float speedInput, turnInput;

    public float bashPow = 20f; 

    public InputActionAsset movementing;
    private InputAction m_left;
    private InputAction rightBash;


    private Vector3 m_moveDirction; 

    //public GameObject startPos;

    public AnimationCurve speedCurve;

    void Awake(){
        // leftBash = movementing.FindAction("LeftBash");
        // rightBash = movementing.FindAction("RightBash");
    }


    void Start()
    {
        //sphereRB.transform.position = startPos.transform.position;
        GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f),Random.Range(0f, 1f));

        sphereRB.transform.parent = null;
        maxSpeed = forwardMove; //set as a baseline so forward move can be reset

        
    }

    public void OnMove(InputValue input){
        m_moveDirction = input.Get<Vector2>();
        //m_left = Input.("LeftBash");

    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 move = new Vector3(0, 0, m_moveDirction.y);
        // transform.Translate(move* forwardMove * forwardMove * Time.deltaTime);
        // transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, m_moveDirction.x * turnStr * Time.deltaTime, 0f));
        // //transform.Translate(move* forwardMove * Time.deltaTime, Space.World);
        // //sphereRB.AddForce(transform.forward * move.x* forwardMove * Time.deltaTime);
        
        
        Movement();
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
    
    void Movement(){
        speedInput = 0f;
        //forward movement
        if (m_moveDirction.y > 0)       //input.getAxis vertical
        {
            speedInput = m_moveDirction.y * forwardMove * 1000 ;    //ask eric how to myltiply by the speed curve
        }
        //reverse movement
        else if (m_moveDirction.y < 0)
        {
            speedInput = m_moveDirction.y * reverseMove * 1000;
        }

        turnInput = m_moveDirction.x;   //turning
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, turnInput * turnStr * Time.deltaTime, 0f));

        if (Input.GetMouseButtonDown(0)){     //LEFT CLICK  Input.GetMouseButtonDown(0)
            //Debug.Log("Pressed left-click.");

            sphereRB.AddForce(transform.right * -bashPow*1000, ForceMode.Impulse);
        }
            
        if (Input.GetMouseButtonDown(1)){    //RIGHT CLICK
            //Debug.Log("Pressed right-click.");
            
            sphereRB.AddForce(transform.right * bashPow*1000, ForceMode.Impulse);
        }

        if(sphereRB.position.y > 1){        //add gravity so player falls off ramps better
            sphereRB.AddForce(Physics.gravity * 0.5f);
            //forwardMove = forwardMove + (forwardMove/2);
            //Physics.gravity
        }
        if(sphereRB.position.y <= 1 ){
            forwardMove = maxSpeed;
        }


        //transform.position = sphereRB.transform.position; //move to the shpere rb

    }



    // void Movement(){
    //     speedInput = 0f;
    //     if (Input.GetAxis("Vertical") > 0)
    //     {
    //         speedInput = Input.GetAxis("Vertical") * forwardMove * 1000;
    //     }
    //     else if (Input.GetAxis("Vertical") < 0)
    //     {
    //         speedInput = Input.GetAxis("Vertical") * reverseMove * 1000;
    //     }

    //     turnInput = Input.GetAxis("Horizontal");
    //     transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, turnInput * turnStr * Time.deltaTime, 0f));

    //     //transform.position = sphereRB.transform.position; //move to the shpere rb

    //     if (Input.GetMouseButtonDown(0)){     //LEFT CLICK  Input.GetMouseButtonDown(0)
    //         //Debug.Log("Pressed left-click.");

    //         sphereRB.AddForce(transform.right * -bashPow*1000, ForceMode.Impulse);
    //     }
            
    //     if (Input.GetMouseButtonDown(1)){    //RIGHT CLICK
    //         //Debug.Log("Pressed right-click.");
            
    //         sphereRB.AddForce(transform.right * bashPow*1000, ForceMode.Impulse);
    //     }

    //     if(sphereRB.position.y > 1){        //add gravity so player falls off ramps better
    //         sphereRB.AddForce(Physics.gravity * 200);
    //         //Physics.gravity
    //     }

    //     transform.position = sphereRB.transform.position; //move to the shpere rb

    // }

}
