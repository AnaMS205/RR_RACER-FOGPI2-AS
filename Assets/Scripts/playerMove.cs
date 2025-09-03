using UnityEngine;
using System.Collections;

public class playerMove : MonoBehaviour
{
    public Rigidbody sphereRB;

    public float forwardMove = 8f, reverseMove = 4f, maxSpeed = 50f, turnStr = 180f;
    // Start is called once before the first execution oated

    private float speedInput, turnInput;

    private bool bashing = true;
    public float bashPow = 20f; 
    public float bashTime = 0.3f;
    public float bashCooldown = 0.75f;


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

        transform.position = sphereRB.transform.position; //move to the shpere rb

        if (Input.GetMouseButtonDown(0) && bashing){     //LEFT CLICK
            Debug.Log("Pressed left-click.");
            StartCoroutine(Bash());
        }
            
        if (Input.GetMouseButtonDown(1))    //RIGHT CLICK
            Debug.Log("Pressed right-click.");

    }

    private void FixedUpdate()
    {
        //sphereRB.AddForce(transform.forward * forwardMove * 1000);
        if (Mathf.Abs(speedInput) > 0)
        {
            sphereRB.AddForce(transform.forward * speedInput);
        }

    }

    private IEnumerator Bash(){     //needs to alter the x value of player position
        bashing = true;

        velocity = new Vector3(transform.forward.x * bashPow, 0f,0f);
        yield return new WaitForSeconds(bashTime);

        velocity = Vector3.zero;
        yield return new WaitForSeconds(bashCooldown);
        bashing = true;
    }
}
