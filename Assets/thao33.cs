using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thao33 : MonoBehaviour
{
    int[,] numberArray;
    int a = 0;
    int b = 1;

    // Start is called before the first frame update
    void Start()
    {
        numberArray = new int[,]
        {
            {1, 2, 4, 2, 6, 1, 7, 8, 6, 5 },
            {7, 3, 1, 9, 1, 8, 6, 10, 11, 17 },
            {10, 21, 1, 3, 5, 9, 2, 4, 12, 18}
        };
        for (int j = 0; j < numberArray.GetLength(0); j++)
        {
            for (int i = 0; i < numberArray.GetLength(1); i++)
            {
                if (numberArray[j, i] % 2 == 0)
                    Debug.Log($"cac so chan trong mang la{numberArray[j, i]}");
                else if (numberArray[j, i] % 2 == 1)
                    Debug.Log($"cac so le trong mang la{numberArray[j, i]}");

                a += numberArray[j, i];
                b *= numberArray[j, i];

                Debug.Log($"tong cac so trong mang la{a}");
                Debug.Log($"tisch cac so trong mang la {b}");

            }
            
        }
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
