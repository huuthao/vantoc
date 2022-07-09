using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hinhtron : MonoBehaviour
{
    int r = 6;
    double Pi = 3.14;

    private void Start()
    {
        // chu vi hinh tron
        Debug.Log(2 * r * Pi);

        // dien tich hinh tron
        Debug.Log(r * r * Pi);
    }
}
