﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningHellaCubes : MonoBehaviour {

    public float Speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, Speed, 0);
	}
}
