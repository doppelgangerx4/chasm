#pragma strict

var player : GameObject;
var PlayerScript : PlayerScript;
var mySelf : GameObject;
var isMouseOver : boolean;
var newPosition : Vector3;
var speed: float;

function Start () {
//player = GameObject.Find("Player");
mySelf = gameObject;
PlayerScript = player.GetComponent.<PlayerScript>();

}

function Update () 
{
//gameObject.GetComponent(ParticleSystem).enabled = true;
if(this.isMouseOver == true && Input.GetMouseButtonDown(0))
	{
	PlayerScript.jumpTo(mySelf);
	
//	iTween.MoveBy(player, iTween.Hash("y", lobHeight, "time", lobTime/2, "easeType", iTween.EaseType.easeOutQuad));
//	iTween.MoveBy(player, iTween.Hash("y", -lobHeight, "time", lobTime/2, "delay", lobTime/2, "easeType", iTween.EaseType.easeInCubic));     
//	iTween.MoveTo(player, iTween.Hash("position", mySelf.transform.position, "time", lobTime, "easeType", iTween.EaseType.linear));

	
	
	}
	
	
if(Input.GetMouseButtonDown(1)){
PlayerScript.jT();
}

}// update

    function OnCollisionEnter() {
   // if(collision.gameObject.tag=="Player"){
    Debug.Log("hit");
   // }
    }

function OnMouseEnter () {
//mySelf.light.enabled = true;
isMouseOver = true;

}

function OnMouseExit () {
//mySelf.light.enabled = false;
isMouseOver = false;

}
