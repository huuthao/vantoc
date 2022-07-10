using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thaovuhan1 : MonoBehaviour
{
    int a = 8;
    int b = 2;
    


    void Start()
    {
        if ((a + b) > 10)
        {
            Debug.Log(a - b);
        }
        else if ((a + b) > 7)
        {
            Debug.Log(a * b);
        }
        else if ((a + b) < 7)
        {
            Debug.Log(a / b);
        }
        else
        {
            Debug.Log("hip hop never die");
        }


    }
}
