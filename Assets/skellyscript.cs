using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skellyscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.A)) 
		{
			GetComponent<Transform> ().position = new Vector3 (transform.position.x - 0.1f, transform.position.y); //movement
		}
		if (Input.GetKey (KeyCode.D)) 
		{
			GetComponent<Transform> ().position = new Vector3 (transform.position.x + 0.1f, transform.position.y); //movement 
		}
		if (Input.GetKey (KeyCode.W)) 
		{
			GetComponent<Transform> ().position = new Vector3 (transform.position.x, transform.position.y + 0.1f); //movement 
		}
		if (Input.GetKey (KeyCode.S)) 
		{
			GetComponent<Transform> ().position = new Vector3 (transform.position.x, transform.position.y - 0.1f); //movement 
		}

		
	}
}
