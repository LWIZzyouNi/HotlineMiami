using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class justDestroyAfterTime : MonoBehaviour
{
    float timeToDestroy;
    public float baseTime;

    // Start is called before the first frame update
    void Start()
    {
        timeToDestroy = baseTime;
    }

    // Update is called once per frame
    void Update()
    {
        timeToDestroy -= Time.deltaTime;
        
        if (timeToDestroy <= 0)
        {
            Destroy(gameObject);
        }
        
    }
}
