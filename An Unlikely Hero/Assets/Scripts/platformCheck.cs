using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformCheck : MonoBehaviour
{
    public bool isGrounded;
    public bool check;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isGrounded != true)
        {
            check = false; 
        }
    }
}
