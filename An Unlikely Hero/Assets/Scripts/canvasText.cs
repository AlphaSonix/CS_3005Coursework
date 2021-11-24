using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class canvasText : MonoBehaviour
{
    public Text winningText;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DisableText", 5f); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DisableText()
    {
        winningText.enabled = false; 
    }
}
