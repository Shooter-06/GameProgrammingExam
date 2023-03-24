using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleComponent : MonoBehaviour
{
    //oncollition enter to check when the player hits the robot
    void OnCollisionEnter(Collision collision)
    {
        if( collision.gameObject.tag == "Player")
        {
            GameManager.Instance.incrementScore(2);
        }

        Destroy(gameObject);
    }
}
