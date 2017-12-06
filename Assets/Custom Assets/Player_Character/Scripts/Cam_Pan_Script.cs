using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_Pan_Script : MonoBehaviour {

	public float sensitivity = 400.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float rotation = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
		transform.Rotate(0, rotation, 0);
	}
}
