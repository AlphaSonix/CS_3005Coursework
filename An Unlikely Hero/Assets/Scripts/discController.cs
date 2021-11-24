using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class discController : MonoBehaviour
{
    public float discSpeedHigh;
    public float discSpeedLow;
    public float discAngle;
    public float discTorqueAngle;  

    Rigidbody2D discRB;

    // Start is called before the first frame update
    void Start()
    {
        discRB = GetComponent<Rigidbody2D>();
        discRB.AddForce(new Vector2(Random.Range(-discAngle, discAngle), Random.Range(discSpeedLow, discSpeedHigh)), ForceMode2D.Impulse);
        discRB.AddTorque(Random.Range(-discTorqueAngle, discTorqueAngle));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
