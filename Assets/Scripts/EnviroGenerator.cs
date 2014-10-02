using UnityEngine;
using System.Collections;

public class EnviroGenerator : MonoBehaviour {
	public GameObject asteroidPrefab;
	public float radius;
	public int asteroidCount;
	void Start () {
		for (int i = 0; i < asteroidCount; ++i) {
			GameObject ast = Instantiate(asteroidPrefab) as GameObject;
			ast.transform.parent = transform;
			ast.transform.localPosition = Random.insideUnitSphere * radius;
			ast.transform.localRotation = Random.rotationUniform;
			float rand = Random.Range(1.0f, 2.0f) * 1.0f;
			ast.transform.localScale = new Vector3(rand, rand, rand);
		}
	}
}
