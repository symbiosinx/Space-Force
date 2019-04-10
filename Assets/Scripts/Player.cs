using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	float speed = 15f;
	float fireRate = 10f;
	public float timer = 0f;

	public GameObject bulletPrefab;
	GameObject bullet;

	void Start() {
		fireRate = 1f / fireRate;
	}
	
	void Update () {
		transform.position += new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"))*speed*Time.deltaTime;

		timer -= Time.deltaTime;
		if (Input.GetMouseButton(0)) {
			while (timer <= 0f) {
				timer += fireRate;
				bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
				bullet.GetComponent<Bullet>().Move(fireRate-timer);
			}
		} else {
			if (timer < 0f) {
				timer = 0f;
			}
		}
	}
}
