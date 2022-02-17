using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using UnityEngine.SceneManagement;


public class test_synManager : MonoBehaviour//構造体はそもそもの分子量とどういう原子の組み合わせで成り立っているのかを管理する配列で成り立たせよう
{
    private int[,] specer=new int[N,N]{{1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                        {0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                        {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                        {0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                        {0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                        {2,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                        {4,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                        {1,1,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                        {2,4,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                        {0,2,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                        {0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                        {2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                        {0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                        {0,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                        {0,3,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                        {3,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                        {4,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                        {0,0,60,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                        {1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
                                        };
    private string[] elements=new string[N]{"H","O","C","Na","S","H2O","CH3COOH","NaOH","H2SO4","CO2","CO","H2","O2","O3","SO3","CH3","C2H4","C60","H2S","gomi"};
    private const int N=20;
    public int[] order=new int[N];
    GameObject database;
    private int wordnum=0;
    public GameObject UI_material;

    // Start is called before the first frame update
    void Start()
    {
        UI_material=GameObject.Find("material");
        database=GameObject.Find("database");
        init();
    }   

    // Update is called once per frame
    void Update()
    {
    }
    public void UIchanger(string tag){
        wordnum++;
        makeArray(tag);
        //show();
        if(wordnum%15==0)UI_material.GetComponent<Text>().text+="\n";
        else if(wordnum<120)UI_material.GetComponent<Text>().text+=tag;
        else UI_material.GetComponent<Text>().text+="";
    }
    public void Onclick(){
        string whats=spec();
        Debug.Log(whats);/////////////////
        database.GetComponent<inSynElData>().add(whats);
        //orderの分を減らす
        for(int i=0;i<N;i++){
            //Debug.Log(i);
            while(true){
                if(order[i]==0)break;
                else{
                    database.GetComponent<inSynElData>().ext(elements[i]);
                    order[i]--;
                }
            }
        }
       UI_material.GetComponent<Text>().text="";
       wordnum=0;
    }
    private string spec(){
        int i,j,count;
        for(i=0;i<N;i++){
            count=0;
            for(j=0;j<N;j++){
                if(order[j]==specer[i,j])count++;
            }
            if(count==N){Debug.Log(i);break;}
        }
        if(i==0)return "H";
        else if(i==1)return "O";
        else if(i==2)return "C";
        else if(i==3)return "Na";
        else if(i==4)return "S";
        else if(i==5)return "H2O";   
        else if(i==6)return "CH3COOH";
        else if(i==7)return "NaOH";
        else if(i==8)return "H2SO4";
        else if(i==9)return "CO2";
        else if(i==10)return "CO";
        else if(i==11)return "H2";
        else if(i==12)return "O2";
        else if(i==13)return "O3";
        else if(i==14)return "SO3";
        else if(i==15)return "CH3";
        else if(i==16)return "C2H4";
        else if(i==17)return "C60";
        else if(i==18)return "H2S";
        else return "gomi";
    }
    public void makeArray(string tag){
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
    }
    private void init(){
        for(int i=0;i<N;i++)order[i]=0;
    }
}
/*
    0:H
    1:O
    2:C
    3:Na
    4:S
    5:H2O
    6:CH3COOH
    7:NaOH
    8:H2SO4
    9:CO2
    10:CO
    11:H2
    12:O2
    13:O3
    14:SO3
    15:CH3
    16:C2H4
    17:C60
    18:H2S
    19:gomi
*/