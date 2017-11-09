using UnityEngine;
using System.Collections;

public class ProjectileDrag : MonoBehaviour {

	public float maxStretch = 3.0f;
	public LineRenderer front;
	public LineRenderer back;

	private SpringJoint2D spring;
	private Transform catapult;
	private Ray rayToMouse;
	private Ray leftCatapultToProjectile;
	private float maxStretchSqr;
	private float circleRadius;
	private bool clickedOn;
	private Vector2 prevVelocity;

	void Awake() {
		spring = GetComponent <SpringJoint2D>();
		catapult = spring.connectedBody.transform;
	}

	void Start () {
		LineRendererSetup();
		rayToMouse = new Ray(catapult.position, Vector3.zero);
		leftCatapultToProjectile = new Ray(front.transform.position, Vector3.zero);
		maxStretchSqr = maxStretch * maxStretch;
		CircleCollider2D circle = GetComponent<Collider2D>() as CircleCollider2D;
		circleRadius = circle.radius;
	}
	
	void Update () {
		if(clickedOn) {
			Dragging();
		}

		if(spring != null) {
			if(!GetComponent<Rigidbody2D>().isKinematic && prevVelocity.sqrMagnitude > GetComponent<Rigidbody2D>().velocity.sqrMagnitude) {
				Destroy (spring);
				GetComponent<Rigidbody2D>().velocity = prevVelocity;
			}

			if(!clickedOn) {
				prevVelocity = GetComponent<Rigidbody2D>().velocity;
			}

			LineRendererUpdate();
		} else {
			front.enabled = false;
			back.enabled = false;
		}
	}

	void LineRendererSetup() {
		front.SetPosition(0, front.transform.position);
		back.SetPosition(0, back.transform.position);

		front.sortingLayerName = "Foreground";
		back.sortingLayerName = "Foreground";

		front.sortingOrder = 3;
		back.sortingOrder = 1;
	}

	void OnMouseDown() {
		spring.enabled = false;
		clickedOn = true;
	}

	void OnMouseUp() {
		spring.enabled = true;
		GetComponent<Rigidbody2D>().isKinematic = false;
		clickedOn = false;
	}

	void Dragging() {
		Vector3 mouseWorldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Vector2 catapultToMouse = mouseWorldPoint - catapult.position;

		if(catapultToMouse.sqrMagnitude > maxStretchSqr) {
			rayToMouse.direction = catapultToMouse;
			mouseWorldPoint = rayToMouse.GetPoint(maxStretch);
		}

		mouseWorldPoint.z = 0f;
		transform.position = mouseWorldPoint;
	}

	void LineRendererUpdate() {
		Vector2 catapultToProjectile = transform.position - front.transform.position;
		leftCatapultToProjectile.direction = catapultToProjectile;
		Vector3 holdPoint = leftCatapultToProjectile.GetPoint(catapultToProjectile.magnitude + circleRadius);
		front.SetPosition(1, holdPoint);
		back.SetPosition(1, holdPoint);
	}
 }
