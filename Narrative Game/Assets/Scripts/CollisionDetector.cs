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
				ItemText.text = "Sofa: Over here’s the waterfall. I like to jump up all the way to the tippy top and then slide down. Sometimes Mr. Whiskers sits on the top of the waterfall, and one time he fell off and ran away.";
			} 
			if (name == "shelf") {
				ItemText.text = "Shelf: This is like a rainbow right in our house. It has books of all different colors and they go all the way up to the sky. You can take one of the books off and it has an entire story inside. The ones on the bottom shelf are all pictures and my dad reads them to me before I go to bed.";
			}
			if (name == "door") {
				ItemText.text = "Door: This is the door. I can’t really reach the handle, but that’s okay. The only things past the door are the kitchen and then the backyard. One time, Mr. Whiskers jumped up and opened the door all by himself! One day, in the future, I’ll be as tall as Mr. Whiskers, maybe even taller.";
			}
			if (name == "lamp") {
				ItemText.text = "Lamp: This is like the sun! I can turn it on and off. When it’s on it’s daytime and when it’s off it’s night. At night, there are monsters that hide in the shadows. When you first come into this room, you have to run over and turn on the light in less than ten seconds or you’ll get eaten!";
			}
			if (name == "tv") {
				ItemText.text = "TV: This magic box is called the TV, and it glows at night. I think there’s a little town trapped inside because I always hear people talking. We have a Wii too, and my dad and I sometimes play bowling. I’m pretty great at it.";
			}
		} else if (!switchPlayer.isToddler) {
			if (name == "sofa") {
				ItemText.text = "Sofa: I really need to get this reupholstered. That stupid cat scratched the entire back up, before we got it declawed. My wife said declawing was cruel, but I think the prices Maurice charges for reupholstery are crueler. Of course, here we are and clearly, this couch still needs to be reupholstered.";
			} 
			if (name == "shelf") {
				ItemText.text = "Shelf: I haven’t even read half the books on this shelf. Every once in a while, I’ll have the urge -- like a minor mid-life crisis --  to read all the classics, so that I can be a well-read member of society. I’ll run to the bookstore and buy a 500-pager, or a book of short stories or poetry. Do I ever read it? No, of course not. I have, though, read all of those kids’ books out loud at least three times each. It’s like my kid goes through new books faster than me.";
			}
			if (name == "door") {
				ItemText.text = "Door: I like this door all right. My wife wants me to oil the hinges, but I like to think a squeaky door is another layer of security against burglars, like creaky steps.";
			}
			if (name == "lamp") {
				ItemText.text = "Lamp: I took this from mom and dad’s house. My wife doesn’t think it matches the rest of the decor, although we hardly have a theme going. With a toddler, it’s safer to not invest in any nice fabrics or furniture. Better to just repair what you’ve got over and over until it falls apart. Yippee.";
			}
			if (name == "tv") {
				ItemText.text = "TV: This is definitely the most expensive thing in here. That, and that Wii. I guess you could combine them into a single unit, a single amenity. Plus, there’s the DVD player (still doesn’t play Blu-ray discs, yet another thing to add to the to-buy list) and the VCR. God, why do we even have a VCR anymore? I haven’t seen a VHS tape since 2007.";
			}
		}

	}

}
