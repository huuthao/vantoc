using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thao32 : MonoBehaviour
{
    int[] timeArray = new int[] { 1, 2, 4, 2, 6, 1, 7, 8, 6, 5 };
   
    int a1 = 0, b1 = 1;
    
    
    // Start is called before the first frame update
    void Start()
    {   // in ra cac so chan
        //for (int i = 0; i < timeArray.Length; i++)
        //{
        //    if (timeArray[i] % 2 == 0)
        //    {
        //        Debug.Log(timeArray[i]);
        //    }
        //}

        // in ra cac so le
        //for (int i = 0; i < timeArray.Length; i++)
        //{
        //    if (timeArray[i] % 2 == 1)
        //    {
        //        Debug.Log(timeArray[i]);
        //    }
        //}

        //tong cac phan tu

        for (int i = 0; i < timeArray.Length; i++)
        {
            a1 += timeArray[i];
            b1 *= timeArray[i];
            
        }
        // tinh tong tich cua mang 1 chieu
        Debug.Log($"tong cac so trong mang 1 chieu la {a1}");
        Debug.Log($"tich cac so trong mang 1 chieu la {b1}");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
