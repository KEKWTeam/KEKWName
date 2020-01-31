using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pruebas : MonoBehaviour
{
    Rigidbody2D rb;
    public float jump_force = 1;
    public float speed_move = 1;
    bool can_jump = true;
    bool can_move = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && can_jump)
        {
            can_jump = false;
            rb.AddForce(Vector2.up * jump_force);
        }

        if (Input.GetKeyDown("right") && can_move)
        {
            rb.AddForce(Vector2.right * speed_move);
        }

        if (Input.GetKeyDown("left") && can_move)
        {
            rb.AddForce(Vector2.left * speed_move);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col.gameObject.tag); //Debug del objeto con el que choca 
        can_jump = true;
        if (col.gameObject.tag == "Ground")
        { //Si el tag es Ground puede saltar 
            can_jump = true;
        }
    }
}
