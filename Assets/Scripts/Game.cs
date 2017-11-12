using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

	/*
	 * This makes it so that I can have a global instance of
	 * the script "playerHealth". This will be useful when collecting
	 * items that increase health, because all of the global instance's
	 * variables are from playerHealth, making it so I can manipulate the
	 * max and current health from every script on the Player.
	 */ 
	public static playerHealth MainPlayer;

	/*
	 * This makes it so that I can have a global instance of
	 * the script "Effect". This will be useful when I collect 
	 * items that will have different names, it will call a different
	 * Effect.
	 */

	public static Effect effect;

	/*
	 * This makes it so that I can have a global instance of
	 * the script "playerHealth". This will be useful when adding
	 * items to the inventory.
	 * 
	 */
	public static Inventory inventory;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
