using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prac_maltitask : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("battle");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator battle(){
        for(int i=0;i<5;i++){
            a();
            yield return new WaitUntil(()=>Input.anyKeyDown);
            yield return null;
            b();
        }
    }
    void a(){
        Debug.Log(1);
    }
    void b(){
        Debug.Log(0);
    }
}
