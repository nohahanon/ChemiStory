using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inCom : MonoBehaviour
{
    [SerializeField] [Header("メッセージ（キャラ名）")] private string[] msgCaraName;
    [SerializeField] [Header("メッセージ（内容）")] private string[] msgContent;
    GameObject objCanvas = null;
    
    // Start is called before the first frame update
    void Start()
    {
        objCanvas = gameObject.transform.Find("Canvas").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine("ShowLog");
        }
    }
    IEnumerator ShowLog()
    {
        GameObject objCaraName = objCanvas.transform.Find("CaraName").gameObject;
        GameObject objContent = objCanvas.transform.Find("Content").gameObject;
 
        objCanvas.SetActive(true);
 
        for (int i=msgCaraName.GetLowerBound(0);i<=msgCaraName.GetUpperBound(0);i++)
        {
            objContent.GetComponent<Text>().text="";
            objCaraName.GetComponent<Text>().text=msgCaraName[i];
            //objContent.GetComponent<Text>().text=msgContent[i];
            for(int j=0;j<msgContent[i].Length;j++){
                yield return StartCoroutine("letswait");
                objContent.GetComponent<Text>().text+=msgContent[i][j];
            }
            yield return new WaitUntil(()=>Input.GetKeyDown(KeyCode.Space));
            yield return null;
        }
 
        objCanvas.SetActive(false);
    }
    IEnumerator letswait()
    {
        yield return new WaitForSeconds(0.01f);
    }
}