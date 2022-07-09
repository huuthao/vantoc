using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tamgiac : MonoBehaviour
{
    int AB = 6;
    int AC = 3;
    int BC = 9;
    int AH = 8;

    private void Start()
    {
        // chu vi tam giac
        Debug.Log(AB + AC + BC);

        // dien tich tam giac
        Debug.Log((BC * AH) / 2);
    }
}
