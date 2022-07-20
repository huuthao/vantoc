using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class no3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //for(int i = 1; i <= 10; i++)
        //{
        //    Debug.Log(i);
        //}
        int tongday = 0;

        for(int i = 1; i <= 10; i++)
        {
            tongday = i + tongday;
        }
        Debug.Log(tongday);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
