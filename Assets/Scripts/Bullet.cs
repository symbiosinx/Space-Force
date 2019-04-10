using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	float speed = 30f;
	float angle = 90f;
	float angleSpeed = 0f;

	void Start() {
	}

	public void Move(float t) {
		transform.position += new Vector3(Mathf.Cos(angle * 0.01745329f), 0f, Mathf.Sin(angle * 0.01745329f))*speed*t;
		angle += angleSpeed * Time.deltaTime;
	}

	void Update () {
		Move(Time.deltaTime);
		if (transform.position.z > 22.5f || transform.position.z < -2.5f || transform.position.x > 10f || transform.position.x < -10f) {
			Destroy(gameObject);
		}
	}
}
