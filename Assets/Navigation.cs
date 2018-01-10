using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour {

    public Rigidbody rb;
    public float speed;
    public float jumpSpeed;
    public float Counter = 0;
    private bool grounded = true;
	// Use this for initialization
	void Start () {
		
	}


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "LevelFloor")
        {
            grounded = true;
            rb.AddExplosionForce(40, transform.position, 4000);
        }
    }

    // Update is called once per frame
    void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
 
        Vector3 move = new Vector3(horizontal, 0, vertical);
        if (Input.GetKey(KeyCode.Space) && grounded == true)
        {
            Debug.Log(Counter);
            Counter++;
            //Vector3 jumping = new Vector3(0, )
            move.y += jumpSpeed;
            
        }
        //rb.ad
        //move.y -= 20.0f * Time.deltaTime;
        rb.velocity = new Vector3(move.x* speed, rb.velocity.y, move.z* speed);

        //rb.AddForce(move * speed * Time.deltaTime);
		
	}
}
