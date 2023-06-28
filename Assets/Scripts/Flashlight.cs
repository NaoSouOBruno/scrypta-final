using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanterna : MonoBehaviour
{

    public Light lanternLight;
    bool isLightOn = false;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            isLightOn = !isLightOn;
            lanternLight.enabled = isLightOn;
        }

    }
}
