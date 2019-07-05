using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptSound : MonoBehaviour {

	public AudioSource sound1;

	void Start () {
		
	}
	

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.transform.tag == "Auto")
		{
			sound1.Play ();
		}
	}
}
