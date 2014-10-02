using UnityEngine;
using System.Collections;

public class HumanPilot : Pilot {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 rudder = new Vector3();
		rudder.x = Input.GetAxis("Y");
		rudder.y = Input.GetAxis("X");
		Quaternion rot = Quaternion.Euler(rudder * 2);
		transform.localRotation *= rot;

		Vector3 thrust;
		thrust.x = Input.GetAxis("StrafeX");
		thrust.y = Input.GetAxis("StrafeY");
		thrust.z = Input.GetAxis("Thrust");
		float mag = thrust.magnitude;
		if (mag > 1) thrust /= mag;

		ship.SetThrust(thrust);
	}
}
