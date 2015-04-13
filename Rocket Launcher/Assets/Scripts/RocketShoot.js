#pragma strict
var force : Vector3;
var relativeTorque:Vector3;
var liftSpeed:float;
var turnSpeed:float;
var activo = 1;

public function lanzar()
{
	activo = 0;
}

function Start () {

//activo = false;
}

function Update () {
if(activo==0){
	constantForce.force=Vector3.up * liftSpeed;
	constantForce.relativeTorque = Vector3(0,turnSpeed,0);
}

}