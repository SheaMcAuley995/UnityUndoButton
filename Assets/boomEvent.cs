using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boomEvent : MonoBehaviour {

    public float boomRange;
    public float boomForce;
    public Vector3 boomPos;
    public bool editorTest;
    public float positionOffset;
	// Use this for initialization
	void Start ()
    {
        boomPos = transform.position + (transform.up * positionOffset);
	}

    void doBoom()
    {
        Collider[] hood = Physics.OverlapSphere(transform.position, boomRange);
        foreach (Collider obj in hood)
        {
            Rigidbody attempt = obj.GetComponent<Rigidbody>();
            if (attempt != null)
            {
                attempt.AddExplosionForce(boomForce, boomPos, boomRange, 0, ForceMode.Impulse);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            //boomPos = other.transform.position;
            Collider[] hood = Physics.OverlapSphere(transform.position, boomRange);
            foreach(Collider obj in hood)
            {
                Rigidbody attempt = obj.GetComponent<Rigidbody>();
                if(attempt != null)
                {
                     attempt.AddExplosionForce(boomForce, boomPos, boomRange, 0, ForceMode.Impulse);
                }
               
            }
        }
    }


    // Update is called once per frame
    void Update () {
		if(editorTest)
        {
            doBoom();
            editorTest = false;
        }
	}
}
