using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playera : MonoBehaviour
{
    private Rigidbody2D myRigidbody2D;
    public float speed=300;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody2D=this.gameObject.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 force=Vector2.zero;
        if(Input.GetKey(KeyCode.LeftArrow))force=new Vector2(speed*-1,0);
        else if(Input.GetKey(KeyCode.RightArrow))force=new Vector2(speed,0);
        //myRigidbody2D.AddForce(force);
        myRigidbody2D.MovePosition(myRigidbody2D.position+force*Time.deltaTime);
    }
}
