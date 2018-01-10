using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour {

    GameObject Rotator;
    public Rigidbody rbs;
    public float speed;
    // Use this for initialization
    void Start () {
        rbs = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if(rbs != null)
        {
            rbs.AddTorque(0, speed, 0);
        }
        
       // transform.Rotate(0, speed , 0 );
	}
}
