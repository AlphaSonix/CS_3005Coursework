using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballController : MonoBehaviour
{

    public float fireballSpeedMax;
    public float fireballSpeedMin;
    public float fireballAngle;
    public float fireballTorqueAngle;

    Rigidbody2D fireballRB; 

    // Start is called before the first frame update
    void Start()
    {
        fireballRB = GetComponent<Rigidbody2D>();
        fireballRB.AddForce(new Vector2(Random.Range(-fireballAngle, fireballAngle), Random.Range(fireballSpeedMin, fireballSpeedMax)), ForceMode2D.Impulse);
        fireballRB.AddTorque(Random.Range(-fireballTorqueAngle, fireballTorqueAngle)); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
