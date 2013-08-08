using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public bool isStuck; //are we stuck to something?
	public float stuckStart = 0; //when did we start sticking?
	public float stuckTimeMax = 2; //how long are we allowed to stay stuck? (in seconds)
	public bool isJumping = false; //are we jumping to a new place?
	public bool isHooking = false; //have we thrown our hook?
	public GameObject jumpTarget; //where are we jumping to?
	public GameObject hookTarget; //where are we hooking to?	
	public GameObject player; //me
		
		
	// Use this for initialization
	void Start () {
	isJumping = false;
	}
	
	// Update is called once per frame
	void Update () {
	
		if(isJumping == true) //if we're jumping somewhere, move us to it each tick
		
		{
		
	//	Debug.Log(jumpTarget.transform.position);
	
		player.transform.position = Vector3.MoveTowards(player.transform.position,jumpTarget.transform.position, (10*Time.deltaTime));
	
		}
			
	}
	
	public void JumpTo(ref GameObject target)
	{
<<<<<<< HEAD:Chasm/chasm/Assets/Chasm Assets/Scripts/PlayerScript.cs
	if (target == null)
		{
			Debug.Log("Invalid target");
		}
		else
		{
			jumpTarget = target;
			isJumping = true;
			Debug.Log(jumpTarget.position);
		}			
=======
	
		jumpTarget = target;
		isJumping = true;
		Debug.Log(jumpTarget.transform.position);
					
>>>>>>> d3cfa2b8f1050f0b91a8e3c94165c971af0806cd:Chasm/chasm/Assets/PlayerScript.cs
	}//jumpTo()
	
	
	
}
