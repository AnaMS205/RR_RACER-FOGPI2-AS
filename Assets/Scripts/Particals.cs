using UnityEngine;

public class Particals : MonoBehaviour
{

    public ParticleSystem cannon_1;
    public ParticleSystem cannon_2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(){
        cannon_1.Play();
        cannon_2.Play();
    }
}
