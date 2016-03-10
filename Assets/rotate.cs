using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButton(0)){
			transform.Rotate (new Vector3 (0, 10, 0) * Time.deltaTime);
		}
	}
}
