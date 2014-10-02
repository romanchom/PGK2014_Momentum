using UnityEngine;
using System.Collections;

public class Track : MonoBehaviour {
	public int gateCount;
	public bool circuit { get; protected set; }
	public GameObject[] gates { get; protected set; }
}
