using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
	//Enemy behaviour
	//public TextMesh scoreText = (TextMesh) GameObject.Find("Score").GetComponent(typeof(TextMesh));
	public TextMesh scoreText;
	bool hit = false;
	public AudioClip shootSound = null;
	private AudioSource audioSource = null;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
		scoreText = (TextMesh) GameObject.Find ("Score").GetComponent <TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//Detect if collosion and play sound and destruct object
	IEnumerator OnCollisionEnter (Collision other){
		if (other.gameObject.name != "Plane") {
			Debug.Log ("Hit!");

			//Debug.Log (scoreText.text);
			if (hit == false) {
				scoreText.text = (int.Parse (scoreText.text) + 1) + "";
				hit = true;
			}
			audioSource.PlayOneShot (shootSound);
			yield return new WaitForSeconds (2);

			Destroy (gameObject);
		} else if (other.gameObject.name != "Plane"){
			Debug.Log ("Missed");
			Debug.Log (other.gameObject.tag);
			Debug.Log (other.gameObject.name + "is name ");
		}
	}
}
