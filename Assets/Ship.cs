﻿using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {
	public float thrustMultiplier;

	float thrust = 0;
	/*void Start() {
		Screen.lockCursor = true;
		Screen.showCursor = false;
	}//*/

	void FixedUpdate() {
		Vector3 mouse = new Vector3();
		mouse.x = -Input.GetAxis("Mouse Y");
		mouse.y = Input.GetAxis("Mouse X");

		mouse.x = Input.GetAxis("Y");
		mouse.y = Input.GetAxis("X");
		Quaternion rot = Quaternion.Euler(mouse);
		transform.localRotation *= rot;

		//thrust += Input.GetAxis("Mouse ScrollWheel") * 1.0f;
		//thrust = Mathf.Clamp01(thrust);
		thrust = -Input.GetAxis("Thrust");
		rigidbody.velocity += transform.forward * thrust * thrustMultiplier * Time.fixedDeltaTime;
	}

	void OnGUI() {
		GUILayout.BeginVertical();
		GUILayout.Label(thrust.ToString());
		GUILayout.EndVertical();
	}
}
