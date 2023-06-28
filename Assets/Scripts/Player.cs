using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Velocity;
    public float Velocity2;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Velocity * Time.deltaTime);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(Vector3.forward * Velocity2 * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Velocity * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Velocity * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Velocity * Time.deltaTime);
        }

    }
}