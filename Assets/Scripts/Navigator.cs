using UnityEngine;
using System.Collections;
using System;

public class Navigator : MonoBehaviour {
	public Track track;
	int currentGate = 0;
	float score = 0;
	public float tolerance;
	float startTime;

	void Start() {
		startTime = Time.time;
	}

	void FixedUpdate() {
		if (currentGate < track.gateCount) {
			Vector3 gatePos = track.gates[currentGate].transform.position;
			Vector3 direction = gatePos - transform.position;
			float distance = direction.magnitude;
			if (distance < tolerance && Vector3.Dot(rigidbody.velocity, direction) < 0) {
				score += distance;
				++currentGate;
				if (currentGate == track.gateCount) {
					float time = Time.time - startTime;
					score /= tolerance;
					score *= 10;
					Debug.Log("You have finished the race. Congrats");
					Debug.Log("Your time: " + formatTime(time));
					Debug.Log("Your penalty: " + formatTime(score));
				}
			}
		}
	}

	string formatTime(float time) {
		return string.Format("{0:00}:{1:00}", time / 60, Mathf.PingPong(time, 60));
	}
}
