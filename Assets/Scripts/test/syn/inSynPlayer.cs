using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inSynPlayer : MonoBehaviour
{
    GameObject database;
    private Rigidbody2D _Rigidbody2D;
    public float speed=30;
    public float jumpForce=800f;
    private int jumpCount=0;
    // Start is called before the first frame update
    void Start()
    {
        database=GameObject.Find("database");
        _Rigidbody2D=this.gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame   
    void Update()
    {    
        Vector2 force=Vector2.zero;
        if(Input.GetKey(KeyCode.LeftArrow))force=new Vector2(speed*-1,0);
        if(Input.GetKey(KeyCode.RightArrow))force=new Vector2(speed,0);
        if(Input.GetKey(KeyCode.Space)&&this.jumpCount<2){
            force=new Vector2(0,jumpForce);
            jumpCount++;
        }
        _Rigidbody2D.AddForce(force);        
    }
    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("wall"))jumpCount=0;
    }
    private void OnTriggerEnter2D(Collider2D other){
        database.GetComponent<inSynElData>().add(other.tag);
        Destroy(other.gameObject);
    }
}
