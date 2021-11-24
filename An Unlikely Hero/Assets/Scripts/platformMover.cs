using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMover : MonoBehaviour
{
    public Transform position1, position2;
    public float speed;
    public Transform startPos;
    //Rigidbody2D myRB;

    Vector3 nextPos;

    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.position;     
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position == position1.position)
        {
            nextPos = position2.position;
        } if(transform.position == position2.position)
        {
            nextPos = position1.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
       // myRB.MovePosition(transform.position + transform.forward * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(position1.position, position2.position);
    }
}
