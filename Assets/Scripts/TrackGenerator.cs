using UnityEngine;
using System.Collections;

public class TrackGenerator : Track {
	public GameObject gatePrefab;
	public float gateSeparation;
	public float gateJaggedness;
	// Use this for initialization
	void Start () {
		gates = new GameObject[gateCount];
		Vector3 position = new Vector3();
		Vector3 direction = Vector3.forward;
		GameObject last = null;
		for (int i = 0; i < gateCount; ++i) {
			direction += Random.onUnitSphere * gateJaggedness;
			direction.Normalize();

			if (last != null) last.transform.localRotation = Quaternion.LookRotation(direction);

			position += direction * gateSeparation;

			last = Instantiate(gatePrefab, position, Quaternion.identity) as GameObject;
			gates[i] = last;
			last.transform.parent = transform;
		}
	}
}
