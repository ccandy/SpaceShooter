using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Bounadary
{
	public float xMax,xMin;
	public float zMax,zMin;
}


public class PlayerController : MonoBehaviour {


	public float speed = 1;
	public Bounadary bounadary;

	public GameObject shot;
	public Transform shotSpawn;

	public float FireRate = 0.5f;
	public float NextFire = 0.0f;

	Rigidbody RB;

	float moveHorizontal;
	float moveVertical;





	// Use this for initialization
	void Start () {
		RB = gameObject.GetComponent<Rigidbody> ();
		
	}


	void Update(){

		NextFire += Time.deltaTime;

		if (Input.GetKeyUp ("p") && NextFire > FireRate ) {
			Instantiate (shot, shotSpawn.position, Quaternion.identity);
			NextFire = 0;
		}
	}


	void FixedUpdate(){
		moveHorizontal 	= Input.GetAxis ("Horizontal");
		moveVertical	= Input.GetAxis ("Vertical");
		RB.velocity 	= new Vector3 (moveHorizontal, 0, moveVertical) * speed;

		RB.position = new Vector3 (
			Mathf.Clamp (RB.position.x, bounadary.xMin, bounadary.xMax),
			0,
			Mathf.Clamp (RB.position.z, bounadary.zMin, bounadary.zMax)
		);


	}
}
