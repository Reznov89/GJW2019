using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public GameObject texto;

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D otro)
    {
        if (otro.gameObject.CompareTag("Finish"))
        {
            texto.SetActive(true);
        }
    }
}
