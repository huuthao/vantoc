using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class no2 : MonoBehaviour
{
    int b;
    // Start is called before the first frame update
    void Start()
    {
       //void kiemtra2so(int a, int b)
       // {
       //     if ((a + b) > 10)
       //         Debug.Log(a - b);
       //     else if ((a + b) > 7)
       //         Debug.Log(a * b);
       //     else
       //         Debug.Log((float) a / b);
                
              
       // }
       void tongchanle(int n)
        {
            int tongchan = 0;
            int tongle = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    tongchan += i;
                else
                    tongle += i;
            }
        }
       



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
