using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // movement variables
    public float maxSpeed;
    //public Transform player;
    
    // jumping variables
    bool grounded = false;
    float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;
    public Transform groundCheck;
    public float jumpHeight; // force we can jump with
    

    Rigidbody2D myRB;
    Animator myAnim;
    bool facingRight;

    //for casting  
    bool attacking = false;
    public Transform handCast;
    public GameObject magic;
    float castRate = 0.5f;
    float nextCast = 0f;
   

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();

        facingRight = true;
    }

    // Update is called once per frame

   
    private void Update()
    {
        if (grounded && Input.GetAxis("Jump") > 0)
        {
            grounded = false;
            myAnim.SetBool("isGrounded", grounded);
            myRB.AddForce(new Vector2(0, jumpHeight));
        }

        // player cast
        if (Input.GetAxisRaw("Fire1") > 0) {
              //myAnim.SetBool("isAttacking", attacking);
            myAnim.SetTrigger("isAttacking");  //animation code needs work 
            castMagic();
            
        }
   
    }
   
    void FixedUpdate()
    {
        //check if we are grounded. If no, then we are falling
        //Draws circle to see if character have intersected the ground
       
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        myAnim.SetBool("isGrounded", grounded);

        myAnim.SetFloat("verticalSpeed", myRB.velocity.y);
       

        float move = Input.GetAxis("Horizontal");
        myAnim.SetFloat("speed", Mathf.Abs(move));
        myRB.velocity = new Vector2(move * maxSpeed, myRB.velocity.y);

        if (move > 0 && !facingRight)
        {
            flip();
        }
        else if (move < 0 && facingRight)
        {
            flip();
        }
    }

    /*
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Platform")
        {
            //myAnim.SetBool("isGrounded", false);
            //Transform movingPlatform = other.gameObject.transform;
            //transform.SetParent(movingPlatform);
            player.SetParent(other.gameObject.transform);
            //transform.position = movingPlatform;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag=="Platform")
        {
            player.SetParent(null);
        }
    }
    */

    void flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void castMagic()
    {
        if (Time.time > nextCast)
        {
            nextCast = Time.time + castRate;
            if (facingRight)
            {
                Instantiate(magic, handCast.position, Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            else if (!facingRight)
            {
                Instantiate(magic, handCast.position, Quaternion.Euler(new Vector3(0, 0, 180f)));
            }
        }
    }
    
}
