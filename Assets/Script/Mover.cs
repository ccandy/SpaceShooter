using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

	// Use this for initialization
	public float speed;

	Rigidbody RB;


	void Start(){
		RB 			= GetComponent<Rigidbody> ();
		RB.velocity = transform.forward * speed;
	}
}
