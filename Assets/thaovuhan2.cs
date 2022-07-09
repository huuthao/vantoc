using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thaovuhan2 : MonoBehaviour
{
    int a = 3;
    int b = 7;
    int c;

    private void Start()
    {
        if (c == 1)
        {
            Debug.Log(a + b + c);
        }
        else if (c == 2)
        {
            Debug.Log(a + b * c);
        }
        else if (c == 4)
        {
            Debug.Log(a * b - (a + b));
        }
        else if (c == 0)
        {
            Debug.Log(a * b * c + c -a);
        }
        else
        {
            Debug.Log("khong co phep tooan nao thoa man");
        }


    }
}
