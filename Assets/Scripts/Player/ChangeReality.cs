using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeReality : MonoBehaviour
{
    bool esRojo = true;
    
    public GameObject pisoRojo,
                      pisoAzul;

void Start(){
  pisoAzul.SetActive(false);

}

    void Update()
    {
        if (Input.GetKey("m"))
        {
         Invoke("CambiarPlano", 0.5f);
        }
    }

    void CambiarPlano()
    {
        if (IsInvoking("CambiarPlano"))
        {
            CancelInvoke();

            if (esRojo)
            {
                esRojo = false;
                pisoAzul.SetActive(true);
                pisoRojo.SetActive(false);

            }
            else
            {
                esRojo = true;

                pisoAzul.SetActive(false);
                pisoRojo.SetActive(true);
            }
        }
    }
}
