using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This camera class manages the current camera
public class CameraChange : MonoBehaviour {

	int cam = 1;//Keeps track of current camera
	Camera myCamera;//FPS CAM

	public GameObject player;//Player
	// Use this for initialization
	void Start () {
		myCamera = GetComponent<Camera> ();

	}
	
	// Update is called once per frame
	void Update () {
		//Use C to change camera mode
		if (Input.GetKeyDown (KeyCode.C)) {
			Debug.Log ("Changing camera");
			if (cam == 1) {
				myCamera.enabled = !myCamera.enabled;
				cam += 1;
				GameObject.Find ("PLAYER").transform.Find ("MultipurposeCameraRig").gameObject.SetActive (true);
			} else if (cam == 2) {
					GameObject.Find ("PLAYER").transform.Find ("MultipurposeCameraRig").gameObject.SetActive (false);
					GameObject.Find ("PLAYER").transform.Find ("FreeLookCameraRig").gameObject.SetActive (true);
					cam += 1;
			} else {
					GameObject.Find ("PLAYER").transform.Find ("FreeLookCameraRig").gameObject.SetActive (false);
					myCamera.enabled = true;
					cam = 1;
			}

		}
	}
}
