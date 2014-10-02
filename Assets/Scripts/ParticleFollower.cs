using UnityEngine;
using System.Collections;

public class ParticleFollower : MonoBehaviour {
	ParticleSystem particleSystem;
	ParticleSystem.Particle[] particles;
	public int pCount;

	void Start() {
		particleSystem = GetComponent<ParticleSystem>();
		//pCount = particleSystem.particleCount;
		particles = new ParticleSystem.Particle[pCount];
	}

	void FixedUpdate() {
		particleSystem.GetParticles(particles);
		for (int i = 0; i < pCount; ++i) {
			Vector3 diff = (transform.position - particles[i].position);
			if (diff.magnitude > 20) {
				particles[i].position += 2 * diff;
			}
		}
		particleSystem.SetParticles(particles, pCount);
	}
}
