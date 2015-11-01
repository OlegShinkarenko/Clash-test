using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	public int speed = 100;

	private float leftRestriction = 68;
	private float rightRestriction = 15;
	private float upRestriction = 85;
	private float downRestriction = 45;


	// Update is called once per frame
	void Update () {

		if ((transform.position.z <= leftRestriction) && Input.mousePosition.y > Screen.height - 2)
			transform.position += transform.forward * Time.deltaTime * speed;

		if ((transform.position.z >= rightRestriction) && Input.mousePosition.y < 2)
			transform.position -= transform.forward * Time.deltaTime * speed;
			
		if ((transform.position.x <= upRestriction) && (int)Input.mousePosition.x > Screen.width - 2)
			transform.position += transform.right * Time.deltaTime * speed;

		if ((transform.position.x >= downRestriction) && (int)Input.mousePosition.x < 2)
			transform.position -= transform.right * Time.deltaTime * speed;

	}
	
}
