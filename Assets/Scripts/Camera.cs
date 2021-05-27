using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
//variables
    public GameObject Obel;
    //public GameObject Evy;
    private Vector3 PosicionCamara;

    // Use this for initialization
    void Start()
    {

        //posicion de la camara - posicion jugador para tener la posicion del jugador
        PosicionCamara = transform.position - Obel.transform.position;
        //PosicionCamara = transform.position - Evy.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {

        //para cambiar la posicion actual de la camara a la del jugador
        transform.position = Obel.transform.position + PosicionCamara;
        //transform.position = Evy.transform.position + PosicionCamara;
    }
}
