using UnityEngine;

public class playerMove : MonoBehaviour
{
    public Rigidbody sphereRB;

    public float forwardMove = 8f, reverseMove = 4f, maxSpeed = 50f, turnStr = 180f;
    // Start is called once before the first execution oated

    private float speedInput, turnInput;
    private bool leftClk, rightClk;
    void Start()
    {
        sphereRB.transform.parent = null;

        leftClk = Input.GetMouseButtonDown(0);    //Left Mouse
        rightClk = Input.GetMouseButtonDown(1);    //Right Mouse
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

        if (leftClk == true)
        {
            Debug.Log("Left Mouse Button");
        }
        if (rightClk == true)
        {
            Debug.Log("Right Mouse Click");
        }

    }

    private void FixedUpdate()
    {
        //sphereRB.AddForce(transform.forward * forwardMove * 1000);
        if(Mathf.Abs(speedInput) > 0){
            sphereRB.AddForce(transform.forward * speedInput);
        }
    }
}
