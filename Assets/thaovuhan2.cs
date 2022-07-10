using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class thaovuhan2 : MonoBehaviour
{
    int a = 3;
    int b = 7;
    int c;
    // Start is called before the first frame update
    void Start()
    {
        switch (c)
        {
            case 1:
                Debug.Log(a + b +c);
                break;
            case 2:
                Debug.Log((a + b) * c);
                break;
            case 4:
                Debug.Log(a * b - (a + b));
                break;
            case 0:
                Debug.Log(a * b * c + c - a);
                break;
                default:
                Debug.Log("khong co phep toan nao thoa man");
                break;
        }
    }

    
}
