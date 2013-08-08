using UnityEngine;
using System.Collections;

public class JumpTo : MonoBehaviour {
	
	private GameObject player; //the player
	private PlayerScript playerScript; //the player's scripting.
	public bool isMouseOver = false; //is mouse over? (sometimes you don't need a comment I guess!)

	//public GameObject mySelf;
	
	
	// Use this for initialization
	void Start () {
		//mySelf = this.gameObject;
		player = GameObject.FindWithTag("Player");
		playerScript = player.GetComponentInChildren<PlayerScript>();		
	}
	
	// Update is called once per frame
	void Update () {
	
		if(isMouseOver == true && Input.GetMouseButtonDown(0)) //if player clicks on me
			{
				playerScript.JumpTo(this.transform); //call the player's JumpTo() to make them jump to me
			}
	}
	
	void OnMouseEnter () {
//mySelf.light.enabled = true;
		this.light.enabled = true;
isMouseOver = true;
		}

void OnMouseExit () {
//mySelf.light.enabled = false;
		this.light.enabled = true;
isMouseOver = false;

}
}

