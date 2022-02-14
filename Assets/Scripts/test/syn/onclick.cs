using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onclick : MonoBehaviour
{
    GameObject script_synMan;
    // Start is called before the first frame update
    void Start()
    {
        script_synMan=GameObject.Find("synManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Onclick(){
        script_synMan.GetComponent<test_synManager>().UIchanger(this.tag);
    }
}
