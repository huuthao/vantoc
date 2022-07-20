using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class no1 : MonoBehaviour
{
    int a;
    
    // Start is called before the first frame update
    void Start()
    {
        {
            for (int i = 0; i < 20; i++)
                Debug.Log("day la vong lap" + i);
        }

        
        while(a < 20)
        {
            a++;
            Debug.Log($"day_la_vong_lap , a = {a}");

        }
 
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
