using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class player : MonoBehaviour {
	float speed=0.1f;
	float speed_r=2;
	CharacterController cc;
	Vector3 v_cam;
	// Use this for initialization
	void Start () {
		cc=GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		float rh=Input.GetAxis("Mouse X");
		float rv=Input.GetAxis("Mouse Y");
		v_cam.x-=rv*speed_r;
		v_cam.y+=rh*speed_r;

		Camera.main.transform.eulerAngles=v_cam;
		if(Input.GetKeyDown(KeyCode.A))
	cc.Move(this.transform.TransformDirection(new Vector3(0,0,speed)));	
	}
}
