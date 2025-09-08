using UnityEngine;
using System.Collections.Generic;

public class playerMove : MonoBehaviour
{
    public Rigidbody sphereRB;

    public float forwardMove = 8f, reverseMove = 4f, maxSpeed = 50f, turnStr = 180f;
    // Start is called once before the first execution oated

    private float speedInput, turnInput;

    public float bashPow = 20f; 

    public float OffRoadMul = 0.75f; //multiply by maxSpeed to slowdown player


    void Start()
    {
        sphereRB.transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
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

        if (Input.GetMouseButtonDown(0)){     //LEFT CLICK
            Debug.Log("Pressed left-click.");

            sphereRB.AddForce(transform.right * -bashPow*1000, ForceMode.Impulse);
        }
            
        if (Input.GetMouseButtonDown(1)){    //RIGHT CLICK
            Debug.Log("Pressed right-click.");
            
            sphereRB.AddForce(transform.right * bashPow*1000, ForceMode.Impulse);
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



}
