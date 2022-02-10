using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text scoreText;
    private int score=0;
    GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        scoreText=this.gameObject.GetComponent<Text>();
        obj=GameObject.Find("obstacles");
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void setScore(){
        score++;
        scoreText.text="score:"+score;
        Debug.Log(obj.transform.childCount);
        if(obj.transform.childCount==1)scoreText.text="game clear!";
    }
}
