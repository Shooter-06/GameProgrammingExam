using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMovement : MonoBehaviour
{
    Rigidbody rigidBody;
    public float force = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;

    }

    // Update is called once per frame for the direction of the player
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidBody.AddForce(new Vector3(-1, 0, 0) * force);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidBody.AddForce(new Vector3(1, 0, 0) * force);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidBody.AddForce(new Vector3(0, 0, 1) * force);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidBody.AddForce(new Vector3(0, 0, -1) * force);
        }
    }
}
