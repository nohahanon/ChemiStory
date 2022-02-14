using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class prac_cs : MonoBehaviour
{
    public int[] aaa=new int[3]{4,5,6};
    public int[] bbb=new int[3];
    struct Mystruct
    {
        public int Num;
        public Mystruct(int num)
        {
            Num=num;
        }
    }
    class Myclass
    {
        public int Num;
        public Myclass(int num)
        {
            Num=num;
        }
    }
    private Mystruct[] structs={new Mystruct{Num=1}};//こういうふうに
    static void MS(Mystruct ms)
    {
        ms.Num*=2;
    }
    static void MC(Myclass mc)
    {
        mc.Num*=2;
    }
    // Start is called before the first frame update
    void Start()
    {
        Mystruct ms=new Mystruct(1);
        Myclass mc=new Myclass(1);   
        MS(ms);
        MC(mc);
        Debug.Log("Mystruct:"+ms.Num);
        Debug.Log("Myclass :"+mc.Num);
        bbb=aaa;
        for(int i=0;i<bbb.Length;i++)Debug.Log(bbb[i]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
