using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AIBehavior : MonoBehaviour {

    GameObject player;
   // Vector3 offset;
    public Rigidbody rbs;
    NavMeshAgent agent;
    public float speed = 8;
    
    // Use this for initialization
    void Start () {
        
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
        //offset = transform.position - player.transform.position;
        player = FindObjectOfType<Navigation>().gameObject;
        rbs = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        //transform.position = player.transform.position;

        // Vector3 move = player.transform.position - transform.position;
        //rbs.AddForce
        // rbs.AddForce(move.normalized * speed * Time.deltaTime);
        agent.destination = player.transform.position;
       
    }
}
