using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class inSynElData : MonoBehaviour
{
    public int O=0;
    public int H=0;
    public int C=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void add(string tag){//主にゲーム画面で
        if(tag.Equals("O"))O++;
        else if(tag.Equals("H"))H++;
        else if(tag.Equals("C"))C++;
    }

    public void ext(string tag){//合成画面で使う予定
        if(tag.Equals("O"))O--;
        else if(tag.Equals("H"))H--;
        else if(tag.Equals("C"))C--;
    }    
}
