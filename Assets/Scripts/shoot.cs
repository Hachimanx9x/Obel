using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform Molotov;
    public GameObject Molo;
    public GameObject Obel;
   private  float next_spawn_time;
    // Start is called before the first frame update
    void Start()
    {
        next_spawn_time = Time.time + 5.0f; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Obel.transform.position.x < transform.position.x) { 
        }
        if (Time.time > next_spawn_time)
        {
            //do stuff here (like instantiate)
            Instantiate(Molo, Molotov.position, Quaternion.identity); 

         //increment next_spawn_time
            next_spawn_time += 5.0f;
        }
    }
}
