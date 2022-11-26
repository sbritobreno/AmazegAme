using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Set camera to follow the player*/
public class camOffset : MonoBehaviour
{
    public GameObject player; 
    private Vector3 offset; 


    void Start()
    {
        offset = transform.position - player.transform.position;
        //Set difference between camera and player position
        //transform.position = position of the camera
        //player.transform.position = position of the player
    }

    void Update()
    {
        transform.position = player.transform.position + offset;

    }
}
