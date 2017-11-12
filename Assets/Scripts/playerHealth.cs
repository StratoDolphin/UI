using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour {
	/*
	 * This script will be put on all NPC's in our game.
	 * 
	 */

	public float maxHealth = 100f;
	public float curHealth = 0f;
	public GameObject healthBar;

	// Use this for initialization
	void Start () {
		//Makes the MainPlayer instance in the Game script this script.
		Game.MainPlayer = this;

		curHealth = maxHealth;
		/*
		 * 
		 * right now I just have it decreasing. 
		 * When we get the animations in, we have to 
		 * put this in the update function and call 
		 * decreaseHealth (not InvokeRepeating)
		 * only if one collided with the 
		 * other and a "swing" or "attack" animation
		 * has been done
		 */

	}
	
	// Update is called once per frame
	void Update () {
	}

	public void decreaseHealth (float healthValue) {
		curHealth -= healthValue;
		if (curHealth < 0) {
			curHealth = 0;
		} else {
			//calculates health lost; if cur = 80 / 100 then 0.8f
			float calcHealth = curHealth / maxHealth;
			SetHealthBar (calcHealth);
		}

	}

	public void increaseHealth(float healthValue) {
		curHealth += healthValue;
		if (curHealth > 100) {
			curHealth = 100;
		} else {
			//calculates health gained; if cur = 80 / 100 then 0.8f
			float calcHealth = curHealth / maxHealth;
			SetHealthBar (calcHealth);
		}
	}

	/*
	 //will use when both npc and player health is made
	void changeHealth (int healthValue) {
		if (curHealth == healthValue)
			return;
		if (healthValue > maxHealth)
			curHealth = maxHealth;
		else if (healthValue >= 0)
			curHealth = healthValue;
		else
			curHealth = 0;
		float calcHealth = curHealth / maxHealth;
		SetHealthBar (calcHealth);
	}﻿
	*/

	public void SetHealthBar(float npcHealth) {
		//npcHealth has to be a value between 0 and 1; max health has scale of 1
		healthBar.transform.transform.localScale = new Vector3 (npcHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);


	}
}
