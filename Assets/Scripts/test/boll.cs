using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boll : MonoBehaviour
{
    private Rigidbody2D myRigidbody2D;
    public float speedX=10;
    public float speedY=10;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody2D=this.gameObject.GetComponent<Rigidbody2D>();
        Vector2 force=new Vector2(speedX,speedY);
        myRigidbody2D.AddForce(force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
