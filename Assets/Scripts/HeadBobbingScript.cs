using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadBobbingScript : MonoBehaviour
{

    public GameObject Camera;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            StartBobbing();
        }

        if(Input.GetKey(KeyCode.S))
        {
            StartBobbing();
        }

        if(Input.GetKeyUp(KeyCode.W))
        {
            StopBobbing();
        }

        if(Input.GetKeyUp(KeyCode.S))
        {
            StopBobbing();
        }

    }

    void StartBobbing()
    {
        Camera.GetComponent<Animator>().Play("HeadBobbing");
    }

    void StopBobbing()
    {
        Camera.GetComponent<Animator>().Play("New State");
    }
}