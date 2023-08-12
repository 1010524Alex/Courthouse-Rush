using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetExhaust : MonoBehaviour
{
    public AudioSource Exhaust;
    // Start is called before the first frame update
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Exhaust.Play();
        }
        
        if (Input.GetKeyUp(KeyCode.W))
        {
            Exhaust.Stop();
        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            Exhaust.Play();
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            Exhaust.Stop();
        }


        if (Input.GetKeyDown(KeyCode.D))
        {
            Exhaust.Play();
        }

        if (Input.GetKeyUp (KeyCode.D))
        {
            Exhaust.Stop();
        }
        

        

        
    }
}
