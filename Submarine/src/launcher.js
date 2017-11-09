// launch code
// put on launcher that should be a child of the camera


static var speed = 100;

var projectile: Rigidbody;


static var magicone = true;


//var shootsound1: AudioClip;
//var shootsound2: AudioClip;
//var shootsound3: AudioClip;

function Update () {
	
	
	
		if(Input.GetButtonDown("Fire1"))
	{
		//audio.PlayOneShot(shootsound1);
		var instantiatedProjectile: Rigidbody = Instantiate(projectile, transform.position, transform.rotation);
		instantiatedProjectile.velocity = transform.TransformDirection(Vector3(0,0,speed));
		Physics.IgnoreCollision(instantiatedProjectile.collider, transform.root.collider);
	
	}
			
}
