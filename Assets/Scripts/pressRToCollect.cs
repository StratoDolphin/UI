using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressRToCollect : MonoBehaviour {

	/* URGENT NEED TO SEE THIS
	 * Scratch this. Put every item that can be collected
	 * into a tag named, "item". Put this script into the player,
	 * so if he collides with an item's isTrigger box collider,
	 * it will allow him to collect it. When the player presses
	 * R, he will get the image and name of the Item 
	 * (so not the tag, instead the name of the objects you create
	 * on the left side) and put it in his inventory.
	 * 
	 */

	private string pressR;
	private string temp;
	private string communicator;
	//need to pass the item into the Inventory
	protected GameObject item;
	//make this a text, then list every item the player collects in the text
	public string inventoryName;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (communicator == "pressR" && Input.GetKeyDown (KeyCode.R)) {
			//Get the tag of the GameObject and send it to the Player's inventory
			/*
			 * The Inventory GUI (not made yet) will have all of the items that the player has collected.
			 * Each Item will have a script giving its "Effect"
			 * When the user clicks on an item in the Inventory GUI, that item's "Effect" function will occur.
			 * It will affect the Player accordingly.
			 */
			//collects item and passes it into the inventory: DONE
			Game.inventory.add2Inventory(inventoryName);
			Destroy (item);
			//Supposed to destroy the item's collider
			Destroy (item.GetComponent<Collider>());
			//takes off the GUI
			temp = null;
		}
	}

	void OnTriggerEnter(Collider otherObjective)
	{
		pressR = "Press R to collect";
		if (otherObjective.tag == "Item" && !(Input.GetKeyDown (KeyCode.R))) {
			communicator = "pressR";
			temp = "<color=white>" + pressR + "</color>";
			//collects the gameObject and name to pass it to inventory
			item = otherObjective.gameObject;
			inventoryName = otherObjective.gameObject.name;
		} 
	}
	void OnTriggerExit(Collider other)
	{
		temp = null;
		communicator = "";
	}
	void OnGUI()
	{
		if (temp != null) {
			GUI.Box (new Rect (0, 400, 1000, 200), temp);
		} 
	}
}
