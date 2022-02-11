using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//所有元素の数を管理する
public class elementList : MonoBehaviour
{
    private string _tag;
    // Start is called before the first frame update
    void Start()
    {
        //int a=Convert.ToInt32("a");
        //Debug.Log(a);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D target){
        _tag=target.gameObject.tag;
        if(_tag=="O");
        else if(_tag=="H");//
    }
}
