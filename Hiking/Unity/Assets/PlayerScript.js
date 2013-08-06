#pragma strict

public var stuckTo : boolean;
public var stuckStart : float; //this is when we started to stick to a platform
public var maxStuckTime : float = 3; // how long we're allowed to stay on a platform before falling
public var isJumping : boolean = false;
public var jumpTarget : GameObject;


var collisionObject : GameObject;
     

function Start () {
isJumping = false;
}

function Update () {


if(isJumping == true){
transform.position = Vector3.MoveTowards(transform.position,jumpTarget.transform.position, 1);
}


}//update



function jumpTo(target){
isJumping = true;
jumpTarget = target;
Debug.Log(jumpTarget.transform.position);
}

function jT(){
Debug.Log(isJumping);
}



    function OnCollisionEnter() {
   // if(collision.gameObject.tag=="Player"){
    Debug.Log("strike");
   // }
    }