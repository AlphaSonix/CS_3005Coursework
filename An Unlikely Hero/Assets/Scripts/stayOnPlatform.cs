using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stayOnPlatform : MonoBehaviour
{
    private GameObject target = null;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        target = null;    
    }

    void OnTriggerStay2D(Collider2D other)
    {
        target = other.gameObject;
        offset = target.transform.position - transform.position; 
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        target = null;
    }

    void LateUpdate()
    {
      if (target != null)
        {
            target.transform.position = transform.position + offset; 
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
