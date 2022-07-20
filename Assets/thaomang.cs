using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thaomang : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PC pc = new PC();
        
    }


    public class PC
    {
        public float Case;
        public string Mainboard;
        private float Ram;
        public float Cpu;
        public float Nguon;
        protected float TanNhiet;
        public float Fan;
        public static float DiachiWifi;
        public static float TocdoWifi;
        public static float ChuSoHuu;

        public PC()
        {

        }


        public PC (float Khoidong, float Tatmay, float Epxung, float Truyennhangiulieu)
        {
            Nguon = Khoidong;
            Ram = Truyennhangiulieu;
            Cpu = Epxung;
            Case = Tatmay;
            Debug.Log("day la phuong thuc vler");
        }

        ~PC()
        {

        }
        


    }

}

