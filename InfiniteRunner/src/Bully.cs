using UnityEngine;
using System.Collections;

public class Bully : MonoBehaviour {

	private float moveSpeed = 12f;

	private Rigidbody2D rigid;

	void Start () {
		//rigid = GetComponent<Rigidbody2D>();
	}
	
	void Update () {

		gameObject.transform.position = new Vector2(transform.position.x + .20f, transform.position.y);
	}

	void OnCollisionEnter2D(Collision2D collision) {

	}
}
