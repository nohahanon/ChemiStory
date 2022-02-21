using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class test_BattleManager : MonoBehaviour
{
    public bool canIgo=false;
    const int N=20;
    int[] order=new int[N];
    public int playerHP=100;
    public int bossHP=1000;
    private int turn=0;
    private int playerPower=10;
    private int bossPower=20;
    GameObject database;
    GameObject attackButton;
    public GameObject UI_playerHP;
    public GameObject UI_bossHP;
    public GameObject UI_turn;
    public GameObject UI_log;
    int damage=0;
    //GameObject battleManager;

    void Init(){
        for(int i=0;i<N;i++)order[i]=0;
    }

    // Start is called before the first frame update
    void Start()
    {
        //battleManager=GameObject.Find("battleManager");
        database=GameObject.Find("database");
        attackButton=GameObject.Find("attackButton");
        Init();
        StartCoroutine("battle");
        //battle();
    }

    // Update is called once per frame
    void Update()
    {
    }
    IEnumerator battle(){
        for(turn=1;judge();turn++){
            if(turn%3==0)boss();
            else {//player's turn
                UI_log.GetComponent<Text>().text+="あなたのターンです\n";
                yield return new WaitUntil(()=>canIgo);
                //接触後少ししてからデストロイ
                bossHP-=damage;
                UI_log.GetComponent<Text>().text+=damage.ToString()+"を与えました\n";
                UI_bossHP.GetComponent<Text>().text=bossHP.ToString();
                canIgo=false;
                Init();
                damage=0;
            }
            UI_turn.GetComponent<Text>().text="turn:"+turn.ToString();
            //UI_log.GetComponent<Text>().text="";
            UI_log.GetComponent<Text>().text+="ターンが更新されます\n";
        }
    }
    private void boss(){
        UI_log.GetComponent<Text>().text+="ボスのターンです\n";
        playerHP-=bossPower;
        UI_playerHP.GetComponent<Text>().text=playerHP.ToString(); 
    }

    private bool judge(){
        if(playerHP<=0||bossHP<=0)return false;//SceneManager.LoadScene("");////SceneManager.LoadScene("");//
        else return true;
    }
    public void add(string tag){
        if(tag.Equals("H"))order[0]++;
        else if(tag.Equals("O"))order[1]++;
        else if(tag.Equals("C"))order[2]++;
        else if(tag.Equals("Na"))order[3]++;
        else if(tag.Equals("S"))order[4]++;
        else if(tag.Equals("H2O"))order[5]++;
        else if(tag.Equals("CH3COOH"))order[6]++;
        else if(tag.Equals("NaOH"))order[7]++;
        else if(tag.Equals("H2SO4"))order[8]++;
        else if(tag.Equals("CO2"))order[9]++;
        else if(tag.Equals("CO"))order[10]++;
        else if(tag.Equals("H2"))order[11]++;
        else if(tag.Equals("O2"))order[12]++;
        else if(tag.Equals("O3"))order[13]++;
        else if(tag.Equals("SO3"))order[14]++;
        else if(tag.Equals("CH3"))order[15]++;
        else if(tag.Equals("C2H4"))order[16]++;
        else if(tag.Equals("C60"))order[17]++;
        else if(tag.Equals("H2S"))order[18]++;
        else order[19]++;
        UI_log.GetComponent<Text>().text+=tag+"が追加されました\n";
        //だめなら加算しない
        //calc damage
        if(tag.Equals("NaOH"))damage+=500;
        else damage+=playerPower;
    }


}
//onclick
