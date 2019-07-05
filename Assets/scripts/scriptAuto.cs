using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptAuto : MonoBehaviour {

	
	Vector3 beginPositie;
	float snelheid;

	void Start () {
		beginPositie = transform.position;
		// transform.position = beginPositie;
		snelheid = Random.Range(2,8);
	}
	

	void Update () {
		if (transform.position.y + Input.GetAxis("Hor")*snelheid*Time.deltaTime > -8 &&
		transform.position.y + Input.GetAxis("Hor")*snelheid*Time.deltaTime < 8)
		{
			transform.Translate(0,-snelheid*Time.deltaTime,0);
		}
		else
		{
			transform.position = beginPositie;
			snelheid = Random.Range(2,8);
		}		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.transform.name == "Player")
		{
			print("Boom");
		}
	}
}