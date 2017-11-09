﻿		// Transforms to act as start and end markers for the journey.
	var startMarker: Transform;
	var endMarker: Transform;
	
	// Movement speed in units/sec.
	var speed = 10.0;
	
	// Time when the movement started.
	private var startTime: float;
	
	// Total distance between the markers.
	private var journeyLength: float;
	
	var Player : Transform;
	var smooth = 5.0;
	
	function Start() {
		// Keep a note of the time the movement started.
		startTime = Time.time;
		
		// Calculate the journey length.
		journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
	}
	
	// Follows the target position like with a spring
	function Update () {
		// Distance moved = time * speed.
		var distCovered = (Time.time - startTime) * speed;
		
		// Fraction of journey completed = current distance divided by total distance.
		var fracJourney = distCovered / journeyLength;
		

		transform.position=Vector3.Lerp(startMarker.position, endMarker.position, Mathf.PingPong(Time.time*speed, 1.0f));
	}