using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Controller : MonoBehaviour {

	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = this.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("Vertical")!=0) {
			anim.SetBool ("Walk",true);
		}else if(Input.GetAxis ("Vertical")!=0) {
			anim.SetBool ("Walk",false);
		}
	}
}
