using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {
	public float thrustMultiplier;
	Vector3 thrust;


	public void SetThrust(Vector3 thrust) {
		this.thrust = thrust;
		
	}

	void FixedUpdate() {
		rigidbody.AddRelativeForce(thrust * thrustMultiplier);
	}

	void OnGUI() {
		GUILayout.BeginVertical();
		GUILayout.EndVertical();
	}
}
