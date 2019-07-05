using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptAnimatie : MonoBehaviour {

	public float FPS;
	public Sprite[] frames;
	private float secWachttijd;
	private int huidigFrame;
	public bool herhaal;

	// Use this for initialization
	void Start () {
		huidigFrame = 0;
		secWachttijd = 1 / FPS;
		StartCoroutine (AnimatieRoutine ());
		GetComponent<SpriteRenderer> ().sprite = frames[0];
	}

	IEnumerator AnimatieRoutine () {
		bool stoppen = false;

		if (huidigFrame >= frames.Length) {
			if (!herhaal) {
				stoppen = true;
			} else {
				huidigFrame = 0;
			}
		}

		yield return new WaitForSeconds (secWachttijd);

		GetComponent<SpriteRenderer> ().sprite = frames[huidigFrame];
		huidigFrame++;

		if (!stoppen) {
			StartCoroutine (AnimatieRoutine ());
		}
	}
}