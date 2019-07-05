using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptSpeler : MonoBehaviour {

	public GUISkin tekstSkin;
	public float snelheid;
	int score;
	Vector3 beginPositie;
	public AudioSource sound1;
	public AudioSource sound2;
	public AudioSource sound3;

	void Start () {
		beginPositie = new Vector3(-4,0,0);
		transform.position = beginPositie;
	}
	
	void Update () {
		if (transform.position.x + Input.GetAxis("Hor")*snelheid*Time.deltaTime < 4 
		&& transform.position.x + Input.GetAxis("Hor")*snelheid*Time.deltaTime > -4)
		{
			transform.Translate(Input.GetAxis("Hor")*snelheid*Time.deltaTime,0,0);
			
		}
		if (transform.position.y + Input.GetAxis("Ver")*snelheid*Time.deltaTime > -6 
		&& transform.position.y + Input.GetAxis("Ver")*snelheid*Time.deltaTime < 6)
		{
			transform.Translate(0,Input.GetAxis("Ver")*snelheid*Time.deltaTime,0);
		}
		if (transform.position.x + Input.GetAxis("Hor")*snelheid*Time.deltaTime > 4)
		{
			sound3.Play();
			transform.position = beginPositie;
			score++;
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.transform.tag == "Auto")
		{
			sound1.Play();
			sound2.Play();
			transform.position = beginPositie;
		}
	}

	void OnGUI()
	{
		GUI.skin = tekstSkin;
		GUI.Label(new Rect(10,10,300,100), "score = " + score);
	}
}