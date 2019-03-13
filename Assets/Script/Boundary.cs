using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour {

	// Use this for initialization

	void OnTriggerExit(Collider other){
		if (other.gameObject.tag == "Bolt") {
			Destroy (other.gameObject);
		}
	}
}