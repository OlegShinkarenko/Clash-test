using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	public int speed = 100;

	public float leftRestriction = 354;
	public float rightRestriction = 48;
	public float upRestriction = 353;
	public float downRestriction = 45;

	// Update is called once per frame
	void Update () {
		if ((transform.position.z <= leftRestriction) && (int)Input.mousePosition.x < 2)
			transform.position -= transform.right * Time.deltaTime * speed;
		if ((transform.position.z >= rightRestriction) && (int)Input.mousePosition.x > Screen.width - 2)
			transform.position += transform.right * Time.deltaTime * speed;



	/*	if ((transform.position.z <= leftRestriction) && (int)Input.mousePosition.x < 2)
			transform.position += transform.forward * Time.deltaTime * speed;
		if ((transform.position.z >= rightRestriction) && (int)Input.mousePosition.x > Screen.width - 2)
			transform.position -= transform.forward * Time.deltaTime * speed;*/

		/*if ((transform.position.x <= upRestriction) && Input.mousePosition.y > Screen.height - 2)
			transform.position += transform.right * Time.deltaTime * speed;
		if ((transform.position.x >= downRestriction) && Input.mousePosition.y < 2)
			transform.position -= transform.right * Time.deltaTime * speed;*/
	}
}
