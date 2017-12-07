using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Movement : MonoBehaviour {

	public float maxSpeed = 4.0f;
	public float acc = 0.2f;
	private float speed = 0.0f;
	private bool slowingDown = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float move = Input.GetAxis ("Vertical");
		if (move > 0 && slowingDown == false) {
			if (speed < maxSpeed) {
				speed += acc;
			} 
		} else {
			if (speed > 0) {
				speed -= acc;
				slowingDown = true;
			} else {
				slowingDown = false;
			}
		}

		this.transform.Translate (0, 0,  speed * Time.deltaTime);
	}
}
