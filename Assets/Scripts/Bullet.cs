using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speed = 30f;
	public float angle = 90f;
	public float angleSpeed = 0f;
	public float damage = 10f;
	public string targetTag;

	void Start() {

	}

	public void Move(float t) {
		transform.position += new Vector3(Mathf.Cos(angle * 0.01745329f), 0f, Mathf.Sin(angle * 0.01745329f))*speed*t;
		angle += angleSpeed * Time.deltaTime;
	}

	void Update () {
		Move(Time.deltaTime);
		if (transform.position.z > 25f || transform.position.z < -5f || transform.position.x > 15f || transform.position.x < -15f) {
			Destroy(gameObject);
		}
	}
		
	void OnTriggerEnter(Collider other) {
		if (other.tag == targetTag) {
			other.gameObject.GetComponent<Enemy>().health -= damage;
			Destroy(this.gameObject);
		}
	}
}
