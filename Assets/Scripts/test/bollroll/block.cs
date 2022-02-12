using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    GameObject gameobject;
    // Start is called before the first frame update
    void Start()
    {
        gameobject=GameObject.Find("Text");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.name=="boll"){
            Destroy(this.gameObject);
            //_UI.setScore();
            gameobject.GetComponent<UI>().setScore();
        }
    }
}