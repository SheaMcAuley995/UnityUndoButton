using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomTest : MonoBehaviour {

    public bool editorTest;
    Rigidbody rb;
    public float boomForce;
    public float boomRadius;
	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	

    void doBoom()
    {
        rb.AddForceAtPosition(transform.up * boomForce, transform.position + transform.up, ForceMode.Impulse);
        //rb.AddExplosionForce(boomForce, transform.position + (transform.up * 4), boomRadius, 0, ForceMode.Impulse);
    }

	// Update is called once per frame
	void Update ()
    {
		if(editorTest)
        {
            doBoom();
            editorTest = false;
        }
	}
}
