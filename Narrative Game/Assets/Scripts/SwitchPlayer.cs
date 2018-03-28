using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlayer : MonoBehaviour {

	SpriteRenderer spriteRenderer;
	public bool isToddler;
	// Use this for initialization
	void Start () {
		isToddler = true;
		spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")) {
			print("space was pressed");
			if (isToddler) {
				isToddler = false;
				spriteRenderer.color = Color.cyan;
			} else if (!isToddler) { // so, is adult
				isToddler = true;
				spriteRenderer.color = Color.white;
			}
			print(isToddler);
		}
	}
}
