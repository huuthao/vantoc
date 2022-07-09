using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tinhvantoc : MonoBehaviour

{
    int quangDuong;
    double thoiGian;
    double vantoc;

    private void Start()
    {
        quangDuong = 20;
        thoiGian = 0.083;
        vantoc = quangDuong / thoiGian;

        Debug.Log(vantoc);
    }
}
