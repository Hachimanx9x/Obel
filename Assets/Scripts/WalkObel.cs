using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkObel : MonoBehaviour
{
    Rigidbody2D RB;
    Animator Anim;
    public float Velocidad;
    bool voltear = true;
    AudioSource Sonido;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>();
        Sonido = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float mover = Input.GetAxis("Horizontal");
        RB.velocity = new Vector2(mover * Velocidad,RB.velocity.y);
        Anim.SetFloat("velocidad", Mathf.Abs(mover));

        if (mover > 0 && !voltear) 
        {
            voltear = !voltear;
            Vector3 escala = transform.localScale;
            escala.x *= -1;
            transform.localScale = escala;
        } 
        
        else if (mover < 0 && voltear) 
         {
            voltear = !voltear;
            Vector3 escala = transform.localScale;
            escala.x *= -1;//para que gire
            transform.localScale = escala;           
        }

        //animacion ataque
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //GetComponent<Animator>().SetBool("Ataque", false);
            Anim.SetBool("Ataque", true);
        }

        else
        {
            //GetComponent<Animator>().SetBool("Ataque", true);
            Anim.SetBool("Ataque", false);
        }

    }
}
