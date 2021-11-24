using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shakyBridge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        GetComponent<Rigidbody2D>().isKinematic = false;
        Destroy(gameObject, 3.0f);
    }
}
