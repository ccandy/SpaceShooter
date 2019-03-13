using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {

	// Use this for initialization


	public float tumble = 1;

	private Rigidbody RB;


	void Start () {
		RB = gameObject.GetComponent<Rigidbody> ();
		RB.angularVelocity = Random.insideUnitSphere * tumble;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
