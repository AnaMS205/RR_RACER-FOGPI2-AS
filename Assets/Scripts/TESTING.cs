using UnityEngine;
using System.Collections;

public class TESTING : MonoBehaviour
{
    //public Rigidbody sphereRB;

    private bool bashing = true;
    public float bashPow = 20f; 
    public float bashTime = 0.3f;
    public float bashCooldown = 0.75f;

    public Vector3 jump;
    public float jumpForce = 2.0f;
    public bool isGrounded;
    public Rigidbody rb; //sphereRB

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0f, 2.0f, 0f);
    }

    void oncollisionStay(){
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            Debug.Log("Pressed left-click.");
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            //StartCoroutine(Bash());
            isGrounded = false;
        }

        if (Input.GetMouseButtonDown(1))
            Debug.Log("Pressed right-click.");
        
    }

    private IEnumerator Bash(){     //needs to alter the x value of player position
        Debug.Log("The bash is active");
        bashing = true;

        //sphereRB.Addforce(transform.forward.x * bashPow, 0f,transform.forward.z * bashPow);

        yield return new WaitForSeconds(bashTime);

        //velocity = Vector3.zero;
        yield return new WaitForSeconds(bashCooldown);
        bashing = true;

            //transform.position = sphereRB.transform.position
    }


}
