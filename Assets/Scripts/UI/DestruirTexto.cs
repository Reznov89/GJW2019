using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirTexto : MonoBehaviour
{
    public float tiempoParaDestruir = 5;

    void Update()
    {
        if (tiempoParaDestruir > 0)
        {
            tiempoParaDestruir -= Time.deltaTime;
        }
        else Destroy(gameObject);
    }
}
