using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {

        transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);

    }
}
