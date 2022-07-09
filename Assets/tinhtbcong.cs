using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tinhtbcong : MonoBehaviour
{
    int a = 12;
    int b = 3;
    int c = 4;
    int d = 5;
    int trungBinhCong;

    private void Start()
    {
        trungBinhCong = (a + b + c + d) / 4;

        Debug.Log(trungBinhCong);
    }




}
