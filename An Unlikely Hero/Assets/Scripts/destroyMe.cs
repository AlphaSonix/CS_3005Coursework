using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyMe : MonoBehaviour
{
    public float aliveTime; 

    // Awake called after an object comes to life
    void Awake()
    {
        Destroy(gameObject, aliveTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
