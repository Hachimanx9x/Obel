using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform Molotov;
    public GameObject Molo;
    public GameObject Obel;
    public int rango=5;
    public float time = 2;
    private  float next_spawn_time;
    Quaternion myRotation;
    // Start is called before the first frame update
    void Start()
    {
        next_spawn_time = Time.time + time;
        Obel = GameObject.FindWithTag("Player");
      
        }
    void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.tag == "Power") {
            Destroy(gameObject);
        }
    }
        // Update is called once per frame
        void Update()
    {
        if (Obel.transform.position.x < transform.position.x && Obel.transform.position.x > transform.position.x - rango )
        {
            var angles = transform.rotation.eulerAngles;
            angles.y = 0;

            var pos = transform.position;
            pos.x -= 0.1f * Time.deltaTime;
            gameObject.transform.SetPositionAndRotation(pos, Quaternion.Euler(angles));
            if (Time.time > next_spawn_time)
            {
                //do stuff here (like instantiate)
                Instantiate(Molo, Molotov.position, transform.rotation);


                //increment next_spawn_time
                next_spawn_time += 5.0f;
            }
        }
        if (Obel.transform.position.x > transform.position.x && Obel.transform.position.x < transform.position.x + rango)
        {
            var angles = transform.rotation.eulerAngles;
            angles.y = 180;
            var pos = transform.position;
            pos.x += 0.1f * Time.deltaTime;
            gameObject.transform.SetPositionAndRotation(pos, Quaternion.Euler(angles));
            if (Time.time > next_spawn_time)
            {
                //do stuff here (like instantiate)
                Instantiate(Molo, Molotov.position, transform.rotation);


                //increment next_spawn_time
                next_spawn_time += time;
            }
        }
      
      
    }
}
