using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public GameObject Obel;
    public GameObject Enemy;
    private Rigidbody2D MyRB;
    private float diry;
    private float X,Y,rangeX,rangeY,rangeUp, rangeDown;
    public float speed=1;
    public int dir=-1;
    public double up = 3.5;
    public float down = 7.5f;
    public float life_time = 5f;
    private float rote;
    private System.Random ran = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        MyRB = GetComponent<Rigidbody2D>();
        rangeUp = (float)(ran.Next(0, (int)up) + ran.NextDouble());
        rangeDown= -(float)(ran.Next(1, (int)down) + ran.NextDouble());
        diry = rangeUp;
        X = transform.position.x;
        Y = transform.position.y;
        rote = transform.rotation.y; 
        rangeX = ran.Next(1, 4);
        rangeY = ran.Next(1, 3);
        life_time = Time.time + 5.0f;
        Obel = GameObject.FindWithTag("Player");
        if (Obel.transform.position.x < transform.position.x)
        {
            dir = -1;
        }
        if (Obel.transform.position.x > transform.position.x)
        {
            dir = 1;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Shield") {
            Destroy(gameObject);
        }
        
       
    }
    // Update is called once per frame
    void Update()
    {

        if (Time.time > life_time) {
            Destroy(gameObject);
        }
        if (transform.position.x > X - rangeX)
        {
            speed += 0.03f;
        }

       
        
        if (transform.position.y > Y + rangeY) {

            diry = rangeDown;
        }
            MyRB.velocity = new Vector2(+speed * dir, +diry);
    }
}
