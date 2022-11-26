using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 0.3f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void LateUpdate()
    {
        // Get the Horizontal and vertical axis using arrow keys.
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        // Move the object's x and z axis
        Vector3 movement = new Vector3(moveH, 0, moveV);

        // Apply the movement to the object
        rb.AddForce(movement * playerSpeed);
    }
}
