using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour {

    public Rigidbody rb;
    public float speed;
    public float jumpSpeed;

    private bool grounded = true;
	// Use this for initialization
	void Start () {
		
	}


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "LevelasFloor")
        {
            grounded = true;
        }
    }

    // Update is called once per frame
    void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
 
        Vector3 move = new Vector3(horizontal, 0, vertical);
        if (Input.GetKey(KeyCode.Space) && grounded == true)
        {
            Debug.Log("Jump");
            //Vector3 jumping = new Vector3(0, )
            move.y += jumpSpeed;
            grounded = false;
        }
        move.y -= 20.0f * Time.deltaTime;

        
        rb.AddForce(move * speed * Time.deltaTime);
		
	}
}
