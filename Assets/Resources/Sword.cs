using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

[RequireComponent(typeof(Animator))]
public class Sword : MonoBehaviour {
	public bool m_Attack = false;
	public int swordDamage = 10;
	Animator m_Animator;

	// Use this for initialization
	void Start () {
		m_Animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!m_Attack) {
			m_Attack = CrossPlatformInputManager.GetButtonDown ("Fire1");
		} 
		else {
			m_Attack = false;
		}
		UpdateAnimator();
	}
	void UpdateAnimator(){
		m_Animator.SetBool ("Attack", m_Attack);
	}
	void OnCollisionEnter(Collision collision)
	{
		var hit = collision.gameObject;
		var ehealth = hit.GetComponent<EnemyHealth> ();
		if (ehealth != null) {
			ehealth.EnemyTakeDamage (swordDamage);
		} 
	}
		void SwordDamage(){
		swordDamage = 10;
		}

	}
