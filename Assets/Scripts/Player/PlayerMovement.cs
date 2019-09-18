using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidadMovimiento = 3f,
                 fuerzaSalto = 3f;
    Rigidbody2D  body2D;
    bool saltando = false;

    void Start()
    {
        body2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey("right") || Input.GetKey("d"))
        {   
            body2D.velocity = new Vector2(velocidadMovimiento, body2D.velocity.y);
        }
        else if (Input.GetKey("left") || Input.GetKey("a"))
        {
            body2D.velocity = new Vector2(-velocidadMovimiento, body2D.velocity.y);
        }
        else if (Input.GetKeyUp("d") || Input.GetKeyUp("a"))
        {
            body2D.velocity = new Vector2(0, body2D.velocity.y);
        }

        if (Input.GetKey("space") && !saltando)
        {
            body2D.velocity = new Vector2 (body2D.velocity.x, fuerzaSalto);
            saltando = true;
        }
    }

    void OnCollisionStay2D(Collision2D otroObjeto)
    {
        if (otroObjeto.gameObject.layer == 10) //si esta tocando el piso
        {
            saltando = false;
        }
    }
}
