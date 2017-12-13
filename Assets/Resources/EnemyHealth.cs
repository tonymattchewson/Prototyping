using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour {
	public const int enemyHealth = 100;
	public int currentHealth = enemyHealth;
	public RectTransform healthBar;

	void Start(){
		PopupTextController.Initialize();

	}

	public void EnemyTakeDamage(int amount){
		PopupTextController.CreateFloatingText (amount.ToString(), transform);
		currentHealth -= amount;
		if (currentHealth <= 0)
		{
			currentHealth = 0;
			Debug.Log ("EnemyDead!");
			Destroy(gameObject);
		}
		healthBar.sizeDelta = new Vector2(currentHealth, healthBar.sizeDelta.y);
	}
}
