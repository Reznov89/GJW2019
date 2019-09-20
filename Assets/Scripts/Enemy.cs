using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    float nearRatio = 10.0f;
    float speed = 0.5f;

    private Vector3 startPosition;
  
    public GameObject player;       //Public variable to store a reference to the player game object
    
    
       void Start()
    {
        if (!player) player = GameObject.FindGameObjectWithTag("Player");
        startPosition = transform.position;
    
    }

     void LateUpdate () 
    {
        float y = transform.position.y;
        float distance = Vector2.Distance(player.transform.position,transform.position);
        Debug.Log(distance);
        float step =  speed * Time.deltaTime; // calculate distance to move
        if (distance<nearRatio){
            Vector3 offset = player.transform.position - transform.position;
            if (Mathf.Abs(offset.x)<0.5f) { //bajar a matarlo
                   
               transform.position = Vector3.MoveTowards(transform.position,player.transform.position, step);
            }
            else{ //buscarlo
                Vector3 newPos = new Vector3 (player.transform.position.x,transform.position.y,transform.position.z);
                transform.position = Vector3.MoveTowards(transform.position,newPos, step);
            }
        }
        else { //volver a casa
            transform.position = Vector3.MoveTowards(transform.position,startPosition, step);
        }


        
    }

}
