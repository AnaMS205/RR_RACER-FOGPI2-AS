using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.InputSystem;
//public Animation graph;
public class playerMove : MonoBehaviour
{
    public Rigidbody sphereRB;

    //[SerializeField] public float forwardMove = 11f;

    public float reverseMove = 4f, turnStr = 170f, forwardMove = 1.1f, maxSpeed =3;
    // Start is called once before the first execution oated 

    private float speedInput, turnInput;

    public float bashPow = 20f; 

    public InputActionAsset movementing;
    private InputAction m_left;
    private InputAction rightBash;

    private Vector2 m_moveDirction; 

    //public AnimationCurve speedCurve;

    //      Bool to control when player can input
    public bool canReceiveInput = true;


    void Start()
    {
        //sphereRB.transform.position = startPos.transform.position;
        //GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f),Random.Range(0f, 1f));

        sphereRB.transform.parent = null;
    }

    public void OnMove(InputValue input){
        
        //m_left = Input.("LeftBash");
        m_moveDirction = input.Get<Vector2>();

    }

    // Update is called once per frame
    void Update()
    {  
        Movement();
        transform.position = sphereRB.transform.position; //move to the shpere rb

        if(transform.position.y > 2){
            sphereRB.AddForce(Physics.gravity * 230);
        }
        
    }

    private void FixedUpdate()
    {
        //sphereRB.AddForce(transform.forward * forwardMove * 1000);
        if (Mathf.Abs(speedInput) > 0)
        {
            sphereRB.AddForce(transform.forward * speedInput);
        }

    }

    public void EnableInput(){
        canReceiveInput = true;
    }
    public void DisableInput(){
        canReceiveInput = false;
    }
    
    void Movement(){
        if (canReceiveInput == true){
            speedInput = 0f;
            //forward movement
            if (m_moveDirction.y > 0)       //input.getAxis vertical
            {
                speedInput = m_moveDirction.y * forwardMove * 10000;  
            }
            //reverse movement
            else if (m_moveDirction.y < 0)
            {
                speedInput = m_moveDirction.y * reverseMove * 10000;
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
        }

    }


}
