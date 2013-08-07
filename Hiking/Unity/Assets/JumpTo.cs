using UnityEngine;
using System.Collections;



public class JumpTo : MonoBehaviour {

	
public GameObject player; //the player
public bool isMouseOver = false; //is mouse over? (sometimes you don't need a comment I guess!)
public PlayerScript PlayerScript; //the player's scripting.
public GameObject mySelf;
	
	
	// Use this for initialization
	void Start () {
		mySelf = this.gameObject;
	PlayerScript = player.GetComponent<PlayerScript>();
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if(isMouseOver == true && Input.GetMouseButtonDown(0)) //if player clicks on me
			{

			PlayerScript.JumpTo(gameObject.transform); //call the player's JumpTo() to make them jump to me
	
			}
	
		
		
	}
	
	void OnMouseEnter () {
//mySelf.light.enabled = true;
isMouseOver = true;
		}

void OnMouseExit () {
//mySelf.light.enabled = false;
isMouseOver = false;

}
}

