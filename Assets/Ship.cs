using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {
	public float thrustMultiplier;

	float thrust = 0;
	void Start() {
		Screen.lockCursor = true;
		Screen.showCursor = false;
	}

	void FixedUpdate() {
		Vector3 mouse = new Vector3();
		mouse.x = -Input.GetAxis("Mouse Y");
		mouse.y = Input.GetAxis("Mouse X");
		Quaternion rot = Quaternion.Euler(mouse * 3);
		transform.localRotation *= rot;

		thrust += Input.GetAxis("Mouse ScrollWheel") * 1.0f;
		thrust = Mathf.Clamp01(thrust);
		rigidbody.velocity += transform.forward * thrust * thrustMultiplier * Time.fixedDeltaTime;
	}

	void OnGUI() {
		GUILayout.BeginVertical();
		GUILayout.Label(thrust.ToString());
		GUILayout.EndVertical();
	}
}
