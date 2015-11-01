using UnityEngine;
using System.Collections;

public class TreeCreator : MonoBehaviour {

	public Transform prefab;
	// Use this for initialization
	void Start () {


		for (int i = 0; i < 17; i++) {
			Instantiate(prefab, new Vector3(i * 8F + 7F, 0, - 5F), Quaternion.identity);
		}
		for (int j = 0; j < 10; j++) {
			Instantiate(prefab, new Vector3(7F, 0, j * 8F + 3F), Quaternion.identity);
		}
		for (int k = 0; k < 10; k++) {
			Instantiate(prefab, new Vector3(135F, 0, k * 8F + 3F), Quaternion.identity);
		}
		for (int z = 0; z < 15; z++) {
			Instantiate(prefab, new Vector3(z * 8F + 15F, 0, 75F), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
