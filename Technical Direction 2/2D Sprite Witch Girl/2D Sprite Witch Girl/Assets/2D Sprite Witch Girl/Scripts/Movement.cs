using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rigBody;
    
    public bool isGrounded = true;
    public float height = 15;
    public float speed = 30;
   
    public Animator anim;
    
    // Use this for initialization
    void Start ()
    {
        rigBody = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            //rigBody.velocity = new Vector2(speed, rigBody.velocity.y);
            rigBody.AddForce(Vector2.up * height, ForceMode2D.Impulse);
            //transform.Translate(Vector2.up * height * Time.deltaTime, Space.World);
            isGrounded = false;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //rigBody.velocity = new Vector2(speed, rigBody.velocity.y);
            transform.Translate(Vector2.left * speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //rigBody.velocity = new Vector2(speed, rigBody.velocity.y);
            transform.Translate(Vector2.right * speed * Time.deltaTime, Space.World);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Platform")
        {
            isGrounded = true;
            anim.SetBool("Jumping", false);
        }
    }

}
