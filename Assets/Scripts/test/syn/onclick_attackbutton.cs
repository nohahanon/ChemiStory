using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onclick_attackbutton : MonoBehaviour
{
    GameObject battleManager;
    // Start is called before the first frame update
    void Start()
    {
        battleManager=GameObject.Find("battleManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Onclick(){
        battleManager.GetComponent<test_BattleManager>().canIgo=true;
    }
}
