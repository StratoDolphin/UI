using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour {

	/*
	 * 
	 * When the user Presses R to Collect, 
	 * it will change the itemName string, which will call 
	 * a certain effect in Update.
	 * NEED TO CREATE AN INSTANCE OF THIS WITHOUT ASSIGNING TO A GAMEOBJECT - it seems like you have to attach it to a GameObject... 
	 * the best option is to attach it to the MainPlayer
	 */ 



	// Use this for initialization
	void Start () {
		//makes Game.whatHappens an instance of the "Effect" script
		Game.effect = this;
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void causeEffect(string itemName) {
		//if the itemName matches, it calls a certain effect: DONE
		//and deletes the item from the Inventory

		if (itemName == "Capsule") {
			Game.MainPlayer.decreaseHealth (15f);
		} else if (itemName == "Cube") {
			Game.MainPlayer.increaseHealth (15f);
		} else {
			itemName = "None";
		}
	}
}
