using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody2D))] Para hacer directamente Rigibody (O lo que sea)
public class Disparo : MonoBehaviour
{
    public Rigidbody2D rigidBody2D;
    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {

        //rigidbody2D = GetComponent<Rigidbody2D>();
        rigidBody2D.velocity = Vector2.up * speed;

        Destroy(gameObject, 2f);

    }

}
