using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleRespwan : MonoBehaviour
{
    public GameObject[] spawnPoint;
    public GameObject prefab;
    public float delay=3;
    public float interval=5;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer=delay;
    }

    // Update is called once per frame
    void Update()
    {
        timer+= Time.deltaTime;
        if(timer>=interval)
        {
            // var position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
            // Instantiate(prefab, position, Quaternion.identity);

            var position = new Vector3(Random.Range(0.0f, 0.0f), transform.position.y,0);
            Destroy(Instantiate(prefab, position, Quaternion.identity),5);
            timer = delay;
        }
    }
}
