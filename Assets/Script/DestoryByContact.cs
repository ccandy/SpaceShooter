using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryByContact : MonoBehaviour {

	// Use this for initialization
	public GameObject explosion;
	public GameObject playerExplosion;


	void OnTriggerEnter(Collider collider){
		//Destroy (collider.gameObject);

		Instantiate (explosion, transform.position, transform.rotation);

		if (collider.tag == "Player") {
			Instantiate (playerExplosion, collider.transform.position, collider.transform.rotation);
		}

		Destroy (collider.gameObject);
		Destroy (gameObject);
	}
}
