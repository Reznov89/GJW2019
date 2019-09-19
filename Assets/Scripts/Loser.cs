using System.Collections;
using System.Collections.Generic;
using  UnityEngine.SceneManagement; 
using UnityEngine;

public class Loser : MonoBehaviour
{
    
    // Update is called once per frame
    void LateUpdate()
    {
        if (transform.position.y<-5)         {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
