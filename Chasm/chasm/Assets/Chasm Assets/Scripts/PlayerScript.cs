using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public bool isStuck = false; //are we stuck to something?
	public bool isFalling = false;
	public float stuckStart = 0; //when did we start sticking?
	public float stuckTimeMax = 5; //how long are we allowed to stay stuck? (in seconds)
	
	public bool isJumping = false; //are we jumping to a new place?
	public bool isHooking = false; //have we thrown our hook?
	public GameObject jumpTarget; //where are we jumping to?
	public GameObject hookTarget; //where are we hooking to?	
	public OVRPlayerController player; //me
	
	
		
	// Use this for initialization
	void Start () {
		isJumping = false;
	}
	
	// Update is called once per frame
	void Update () {
	Debug.Log(Time.time);
		if(isJumping == true) //if we're jumping somewhere, move us to it each tick

		{
		player.transform.position = Vector3.MoveTowards(player.transform.position,jumpTarget.transform.position, (10*Time.deltaTime));
		}
		
		if( (player.transform.position == jumpTarget.transform.position) && isJumping ){ // we made it!
			isJumping = false;
			isStuck = true;
			stuckStart = Time.time;
			}
		
		if(isStuck && ((stuckStart + stuckTimeMax) < Time.time)){ //oh no i'm falling
			isFalling = true;
			}
		
		if (isFalling){
			player.transform.position += Vector3.down;
			}
			
	}
	
	public void JumpTo(ref GameObject target, float rockStuckTime)
	{
		jumpTarget = target;
		isJumping = true;
		Debug.Log(jumpTarget.transform.position);
		stuckTimeMax = rockStuckTime;
	}//jumpTo()
	
	
	public void OnControllerColliderHit(ControllerColliderHit hit)
{
//Respond to collision
Debug.Log("test");
}
	
		public void OnCollisionEnter (Collision col)
		{
		//Respond to collision
		Debug.Log("test");
		}
	
}