using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_Roll_Script : MonoBehaviour {

	public float sensitivity = 400.0f;
	public float limit = 0.4f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float rotation = - Input.GetAxis ("Mouse Y") * sensitivity * Time.deltaTime;
		if((rotation > 0.0f && this.transform.localRotation.x < limit) || (rotation < 0.0f && this.transform.localRotation.x > -limit))
			this.transform.Rotate (rotation, 0, 0);
	}
}
