using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetector : MonoBehaviour {

	// Use this for initialization
	public Text ItemText;

	void OnCollisionEnter2D(Collision2D coll) {
		print ("Hit " + coll.gameObject.name);
		ChangeText(coll.gameObject.name);
	}

	void ChangeText(string name) {
		if (name == "sofa") {
			ItemText.text = "Sofa was hit";
		} 
		if (name == "shelf") {
			ItemText.text = "Shelf was hit";
		}
		if (name == "door") {
			ItemText.text = "Door was hit";
		}
		if (name == "lamp") {
			ItemText.text = "Lamp was hit";
		}

	}

}
