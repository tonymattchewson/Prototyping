using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAI : MonoBehaviour {
	public float timeBetweenAttacks = 1.5f;
	public float timer;

	void Update(){
		timer += Time.deltaTime;
	}

	void OnCollisionEnter(Collision collision)
	{
		var hit = collision.gameObject;
		var health = hit.GetComponent<Health>();
		if (health  != null && timer >= timeBetweenAttacks)
		{
			timer = 0f;
			health.TakeDamage(10);
		}
	}
}
