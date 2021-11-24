using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColour : MonoBehaviour
{

    private Renderer rend;

    [SerializeField]
    private Color colorToTurnTo = Color.green;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = colorToTurnTo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
