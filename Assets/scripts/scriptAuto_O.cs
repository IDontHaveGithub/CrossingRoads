using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptAuto_O : MonoBehaviour {

	public GUISkin tekstSkin;
	Vector3 beginPositie;
	float snelheid;
	public int score=0;
	public int minus=0;


	void Start () {
		beginPositie = new Vector3(-4,0,0);
		transform.position = beginPositie;
	}
	

	void Update () {
		if (transform.position.x + Input.GetAxis("Hor")*snelheid*Time.deltaTime < 4)
		{
			snelheid = Random.Range(2,8);
			transform.Translate(snelheid*Time.deltaTime,0,0);
		}
		else
		{
			transform.position = beginPositie;
			score++;
		}
	}

	void OnGUI()
	{
		GUI.skin = tekstSkin;
		GUI.Label(new Rect(10,10,300,100), "score = " + score);
		GUI.Label(new Rect(10,60,300,100), "hit = " + minus);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.transform.name == "Player")
		{
			print("Boom");
			transform.position = beginPositie;
			minus--;
		}
	}
}
