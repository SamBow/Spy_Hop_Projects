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
		//gameObject.transform.Translate(Vector2.right * 0.25f);
		//transform.position = new Vector3(transform.position.x, player.position.y, moveSpeed * Time.time);
		//rigid.velocity = new Vector2(moveSpeed, rigid.velocity.y);
		//bully.transform.position = new Vector2(bully.transform.position.x, player.transform.position.y);
	}

	void OnCollisionEnter2D(Collision2D collision) {

	}
}
