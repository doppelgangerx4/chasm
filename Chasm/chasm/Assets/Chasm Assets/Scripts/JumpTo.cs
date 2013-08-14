using UnityEngine;
using System.Collections;

public class JumpTo : MonoBehaviour {
	
	private GameObject player; //the player
	private PlayerScript playerScript; //the player's scripting.
	
	public bool isMouseOver = false; //is mouse over? (sometimes you don't need a comment I guess!)
	public GameObject mySelf;
	private Color nativeLightColor;
	
	public string myColor; //We can enter colors into each rock, and the rock's color/stuckTime will change as a result.
	public float myStuckTime; //length of time player can stick to me
	
	
	// Use this for initialization
	void Start () {
		mySelf = this.gameObject;
		player = GameObject.FindWithTag("Player");
		playerScript = player.GetComponentInChildren<PlayerScript>();
		
		switch(myColor){
		
		case "Red":
		light.color = Color.red;
		myStuckTime = 2.5f;
		break;
			
		case "Orange":
		light.color = Color.Lerp(Color.red,Color.yellow,0.5f);
		myStuckTime = 4.5f;
		break;	
		
		case "Yellow":
		light.color = Color.yellow;
		myStuckTime = 7f;
		break;
			
			
		}	
			
		
		nativeLightColor = light.color;
	}
		
		
		
		
		
	
	
	// Update is called once per frame
	void Update () {
	
		if(isMouseOver == true && Input.GetMouseButtonDown(0)) //if player clicks on me
			{
				playerScript.JumpTo(ref mySelf, myStuckTime); //call the player's JumpTo() to make them jump to me
			}
	}
	
	void OnMouseEnter () {
//mySelf.light.enabled = true;
		light.color = Color.white;
		//light.enabled = true;
isMouseOver = true;
		}

void OnMouseExit () {
//mySelf.light.enabled = false;
		//this.light.enabled = true;
		light.color = nativeLightColor;
isMouseOver = false;

}
}

