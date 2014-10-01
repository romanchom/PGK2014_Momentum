using UnityEngine;
using System.Collections;

public class TrackGenerator : MonoBehaviour {
	public GameObject gatePrefab;
	public int gateCount;
	public float gateSeparation;
	public float gateJaggedness;
	// Use this for initialization
	void Start () {
		Vector3 position = new Vector3();
		Vector3 direction = Vector3.forward;
		for (int i = 0; i < gateCount; ++i) {
			direction += Random.onUnitSphere * gateJaggedness;
			direction.Normalize();

			position += direction * gateSeparation;

			(Instantiate(gatePrefab, position, Quaternion.identity) as GameObject).transform.parent = transform;
		}
	}
}
