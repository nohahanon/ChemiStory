using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onclick : MonoBehaviour
{
    GameObject script_synMan;
    GameObject database;
    // Start is called before the first frame update
    void Start()
    {
        script_synMan=GameObject.Find("synB");
        database=GameObject.Find("database");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Onclick(){
        if(!(database.GetComponent<inSynElData>().judge(this.tag)))Debug.Log("no!");
        else script_synMan.GetComponent<test_synManager>().UIchanger(this.tag);
    }
}
