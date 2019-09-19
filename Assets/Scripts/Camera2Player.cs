using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2Player : MonoBehaviour
{
    
    public GameObject player;       //Public variable to store a reference to the player game object
    private Vector3 offset;         //Private variable to store the offset distance between the player and camera

    
       void Start()
    {
        if (!player) player = GameObject.FindGameObjectWithTag("Player");
        offset = transform.position - player.transform.position;
    }

     void LateUpdate () 
    {
      float y = transform.position.y;
        Vector3  position = player.transform.position + offset;
        position.y=y;
        transform.position= position;
    }
}
