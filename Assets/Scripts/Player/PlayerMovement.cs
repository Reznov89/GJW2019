using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidadMovimiento = 3f,
                 fuerzaSalto = 3f;
    Rigidbody2D  body2D;
    bool saltando = false;

    Animator animator;

    public Transform ninjaCenter;

    void Start()
    {
        body2D = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey("right") || Input.GetKey("d"))
        {   
            body2D.velocity = new Vector2(velocidadMovimiento, body2D.velocity.y);
            animator.SetBool("movimiento", true);
            ninjaCenter.localScale = new Vector3(1, 1, 1);
        }
        else if (Input.GetKey("left") || Input.GetKey("a"))
        {
            body2D.velocity = new Vector2(-velocidadMovimiento, body2D.velocity.y);
            animator.SetBool("movimiento", true);
            ninjaCenter.localScale = new Vector3(-1, 1, 1);
        }
        else if (Input.GetKeyUp("d") || Input.GetKeyUp("a"))
        {
            body2D.velocity = new Vector2(0, body2D.velocity.y);
            animator.SetBool("movimiento", false);
        }

        if (Input.GetKey("space") && !saltando)
        {
            body2D.velocity = new Vector2 (body2D.velocity.x, fuerzaSalto);
            saltando = true;
            animator.SetBool("saltando",true);
        }
    }

    void OnCollisionStay2D(Collision2D otroObjeto)
    {
        if (otroObjeto.gameObject.layer == 10) //si esta tocando el piso
        {
            saltando = false;
            animator.SetBool("saltando", false);
        }
    }
}
