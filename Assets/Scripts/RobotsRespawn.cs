using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotsRespawn : MonoBehaviour
{
    public GameObject[] spawnPoint;
    public GameObject prefab;
    public float delay = 2; // Change delay to 2 seconds
    float timer; 
    public float interval=5;
    // Start is called before the first frame update
    void Start()
    {
        timer = delay;
    }

    // Update is called once per frame
    void Update()
    {
        // timer -= Time.deltaTime;
        // timer -= Time.deltaTime;
        timer -= Time.deltaTime;
        if (timer<= 0)
        {
            var position = new Vector3(Random.Range(0.5f, 0.5f), transform.position.y,5);

            // if(interval==5)
            // {
            //     Destroy(Instantiate(prefab, position, Quaternion.identity),5);
            //     timer = delay;
            // }

            Destroy(Instantiate(prefab, position, Quaternion.identity),5);
            timer = delay;
        }
    }
}