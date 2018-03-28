using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetector : MonoBehaviour {

	// Use this for initialization
	public Text ItemText;
	
	SwitchPlayer switchPlayer;

	void Start() {
		switchPlayer = gameObject.GetComponent<SwitchPlayer>();
		
	}

	void OnCollisionEnter2D(Collision2D coll) {
		print ("Hit " + coll.gameObject.name);
		ChangeText(coll.gameObject.name);
	}


	void ChangeText(string name) {
		if(switchPlayer.isToddler) {
			if (name == "sofa") {
				ItemText.text = "Over here’s the waterfall. I like to jump up all the way to the tippy top and then slide down. Sometimes Mr. Whiskers sits on the top of the waterfall, and one time he fell off and ran away.";
			} 
			if (name == "shelf") {
				ItemText.text = "This is like a rainbow right in our house. It has books of all different colors and they go all the way up to the sky. You can take one of the books off and it has an entire story inside. The ones on the bottom shelf are all pictures and my mom likes to read me them before I go to bed.";
			}
			if (name == "door") {
				ItemText.text = "Door was hit";
			}
			if (name == "lamp") {
				ItemText.text = "Lamp was hit";
			}
			if (name == "tv") {
				ItemText.text = "TV was hit";
			}
		} else if (!switchPlayer.isToddler) {
			if (name == "sofa") {
				ItemText.text = "Sofa was hit -2";
			} 
			if (name == "shelf") {
				ItemText.text = "Shelf was hit2";
			}
			if (name == "door") {
				ItemText.text = "Door was hit2";
			}
			if (name == "lamp") {
				ItemText.text = "Lamp was hit2";
			}
			if (name == "tv") {
				ItemText.text = "TV was hit2";
			}
		}

	}

}
