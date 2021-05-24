using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private GameObject Obel;
    // Start is called before the first frame update
    void Start()
    {
        Obel = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        var pos = Obel.transform.position;
   
        transform.position = Obel.transform.position; 
    }
}
