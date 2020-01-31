using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    Rigidbody2D rb;
    public float jumpforce = 1;
    bool canjump = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && canjump) {
            canjump = false;

            rb.AddForce(Vector2.up * jumpforce);
        }


    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col.gameObject.tag); //Debug del objeto con el que choca 
        canjump = true;
        if(col.gameObject.tag == "Ground"){ //Si el tag es Ground puede saltar 
            canjump = true;
        }
    }

    void Teclas() {
    
    
    
    }
}
