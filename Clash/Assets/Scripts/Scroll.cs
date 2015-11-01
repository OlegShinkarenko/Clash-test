using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {

	private float yRotation;
	private float maxYrotation = 75;
	private float minYrotation = 65;
	private float scrollSpeed = 300;

	void Update () { 

		yRotation -= Input.GetAxis("Mouse ScrollWheel") * scrollSpeed * Time.deltaTime;
		yRotation = Mathf.Clamp(yRotation, minYrotation, maxYrotation);
		transform.localEulerAngles = new Vector3(yRotation, 0, 0);

	}
}
	