using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    public float speed = 0;



    private Rigidbody2D rigidbody2D;
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector2(Input.GetAxis("Horizontal"), 0);

        //tranform.Translate(new Vector2(2, 5)); si quieres que se muva a esa posicion
        transform.Translate(direction * speed * Time.deltaTime);
    }


    private void FixedUpdate()
    {
        //TranslateMovement();
        //AddingForceMovement();
        //VelocityMovement();
        MovePositionMovement();
    }

    void MovePositionMovement()
    {
        rigidbody2D.MovePosition((Vector2)transform.position + (speed * direction * Time.fixedDeltaTime));
    }

    void VelocityMovement()
    {
        rigidbody2D.velocity = direction * speed;
    }

    void AddingForceMovement()
    {
        rigidbody2D.AddForce(direction * speed);
    }

    void TranslateMovement()
    {
        transform.Translate(direction * speed * Time.fixedDeltaTime);
    }
}
