using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject Bullet;
    public float cooldown = 2;

    public float lastshoot = 0;
    // Start is called before the first frame update
    void Update()
    {
        if (Time.time > lastshoot + cooldown || lastshoot == 0)
        {
            if (Input.GetKey("space"))
            {
                foreach (Transform child in transform)
                {
                    Instantiate(Bullet, child.position, Quaternion.identity);
                }
                lastshoot = Time.time;


            }
        }
    }   

  
}
