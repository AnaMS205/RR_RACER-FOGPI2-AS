using UnityEngine;

public class TESTING : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Debug.Log("Pressed left-click.");

        if (Input.GetMouseButtonDown(1))
            Debug.Log("Pressed right-click.");
        
    }
}
