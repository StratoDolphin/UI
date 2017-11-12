using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Inventory : MonoBehaviour {

	public string items;
	private string temp = null;
	private string[] itemInventory;
	private int itemNum = 1;

	//show/hide GUI
	private bool isShowing;

	// Use this for initialization
	void Start () {
		Game.inventory = this;
		isShowing = false;
	}
	
	// Update is called once per frame
	void Update () {
		/*
		 * When pressing I the first time, GUI should show.
		 * When pressing I the second time, GUI should hide.
		 * Tried to do it, but wouldn't work.
		 */ 

		//When I is pressed, show Inventory GUI
		if (Input.GetKey (KeyCode.I) && isShowing == false) {
			isShowing = true;
			showInventory ();
			Debug.Log (isShowing);
		} else if (Input.GetKey (KeyCode.I) && isShowing == true) {
			temp = null;
			isShowing = false;
			Debug.Log (isShowing);
		}

		//When C is pressed, hide Inventory GUI
		if (Input.GetKey(KeyCode.C) && isShowing) {
			temp = null;
			isShowing = false;
			Debug.Log (isShowing);
		}
	}

	public void showInventory() {

		//make items have the ability to get newlines, and put all of the items in an Array.
		items = items.Replace ("\\n", "\n");
		itemInventory = items.Split ('`');

		//put array in alphabetical order and count amount of items that are the same. Set temp to the item name + the number of items
		//Array.Sort(itemInventory);
		for (int i = 0; i < itemInventory.Length; i++) {
			//will throw error if 0
			if (i != itemInventory.Length - 1) {
				if (i == itemInventory.Length - 1) {
					//if it's the last item in the inventory list, add it to the inventory screen with the item's amount.
					temp += itemNum + " " + itemInventory [i];
					itemNum = 0;
				} else if (itemInventory [i] == itemInventory [i + 1]) {
					//if the item is the same as the item after it, increase the number of that item we have in the inventory
					itemNum++;
				} else {
					//if neither, then that means that we changed items. Add it to the inventory screen with the item's amount.
					temp += itemNum + " " + itemInventory [i];
					itemNum = 0;
				}
			} else {
				//last item, so automatically increase itemNum
				itemNum++;
			}
		}
	}

	public void add2Inventory(string item) {
		items += item + "\\n`";
	}

	void OnGUI() {
		if (temp != null) {
			GUI.Box (new Rect (0, 400, 1000, 200), temp);
		}
	}
}
