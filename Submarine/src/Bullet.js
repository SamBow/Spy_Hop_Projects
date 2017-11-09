var Bullet : Transform;
var SpawnPoint : Transform;
var Speed : float;
var ShootSound : AudioClip;

function Start () {

}

function Update () {
if(Input.GetKeyDown(KeyCode.Mouse0))
{
		// bullet spawnpoint
		var Bullet = Instantiate(Bullet, SpawnPoint.transform.position, SpawnPoint.transform.rotation);
		Bullet.rigidbody.AddForce(transform.forward * Speed);

		audio.PlayOneShot(ShootSound);
	}
}
function OnTriggerEnter (other : Collision) {
	
}