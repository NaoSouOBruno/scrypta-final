using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flick : MonoBehaviour
{
    public int contador = 0;
    public Light lanternLight;
    bool isLightOn = false;
    
    void Start()
    {
        InvokeRepeating("Contador", 1f, 1f);
    }

    void Contador()
    {
        contador ++;
    }

    void Update()
    {
        if (contador % 10 == 0)
        {
            isLightOn = !isLightOn;
            lanternLight.enabled = isLightOn;
        }
    }
}