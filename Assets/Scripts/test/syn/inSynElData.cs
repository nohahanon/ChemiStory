using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class inSynElData : MonoBehaviour
{
    public bool DontDestroyEnabled = true;
    public const int N=20;
    public int[] order=new int[N];
    // Start is called before the first frame update
    void Start()
    {
        if (DontDestroyEnabled) {
　　       // Sceneを遷移しても消えない
        DontDestroyOnLoad (this);
        }
        for(int i=0;i<N;i++)order[i]=0;
        order[0]=2;//
        order[1]=1;//
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void add(string tag){//主にゲーム画面で
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
        else if(tag.Equals("gomi"))order[19]++;
    }

    public void ext(string tag){//合成画面で使う予定
        if(tag.Equals("H"))order[0]--;
        else if(tag.Equals("O"))order[1]--;
        else if(tag.Equals("C"))order[2]--;
        else if(tag.Equals("Na"))order[3]--;
        else if(tag.Equals("S"))order[4]--;
        else if(tag.Equals("H2O"))order[5]--;
        else if(tag.Equals("CH3COOH"))order[6]--;
        else if(tag.Equals("NaOH"))order[7]--;
        else if(tag.Equals("H2SO4"))order[8]--;
        else if(tag.Equals("CO2"))order[9]--;
        else if(tag.Equals("CO"))order[10]--;
        else if(tag.Equals("H2"))order[11]--;
        else if(tag.Equals("O2"))order[12]--;
        else if(tag.Equals("O3"))order[13]--;
        else if(tag.Equals("SO3"))order[14]--;
        else if(tag.Equals("CH3"))order[15]--;
        else if(tag.Equals("C2H4"))order[16]--;
        else if(tag.Equals("C60"))order[17]--;
        else if(tag.Equals("H2S"))order[18]--;
        else if(tag.Equals("gomi"))order[19]--;
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