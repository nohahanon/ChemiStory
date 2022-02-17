using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ManagerSceneAutoLoader{

  //ゲーム開始時(シーン読み込み前)に実行される
  [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
  private static void LoadManagerScene(){
    string managerSceneName = "test_database";

    //ManagerSceneが有効でない時(まだ読み込んでいない時)だけ追加ロードするように
    if(!SceneManager.GetSceneByName (managerSceneName).IsValid()){
      SceneManager.LoadScene (managerSceneName, LoadSceneMode.Additive);
    }
  }

}

public class inSynElData : MonoBehaviour
{
    int index;
    public bool DontDestroyEnabled = true;
    public const int N=20;
    public int[] order=new int[N];
    void Awake()
    {
        DontDestroyOnLoad(this);
    }
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<N;i++)order[i]=0;
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
        else order[19]++;
    }

    public void ext(string tag){//合成画面で使う予定
    //Debug.Log(tag);
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
    public bool judge(string tag){
        //添え字特定　添え字0なら0返す　それいがいで1返す
        if(tag.Equals("H"))index=0;
        else if(tag.Equals("O"))index=1;
        else if(tag.Equals("C"))index=2;
        else if(tag.Equals("Na"))index=3;
        else if(tag.Equals("S"))index=4;
        else if(tag.Equals("H2O"))index=5;
        else if(tag.Equals("CH3COOH"))index=6;
        else if(tag.Equals("NaOH"))index=7;
        else if(tag.Equals("H2SO4"))index=8;
        else if(tag.Equals("CO2"))index=9;
        else if(tag.Equals("CO"))index=10;
        else if(tag.Equals("H2"))index=11;
        else if(tag.Equals("O2"))index=12;
        else if(tag.Equals("O3"))index=13;
        else if(tag.Equals("SO3"))index=14;
        else if(tag.Equals("CH3"))index=15;
        else if(tag.Equals("C2H4"))index=16;
        else if(tag.Equals("C60"))index=17;
        else if(tag.Equals("H2S"))index=18;
        else if(tag.Equals("gomi"))index=19;

        if(order[index]==0)return false;
        else return true;
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