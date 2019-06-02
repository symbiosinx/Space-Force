using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	Vector3 startPos;
	public float health = 100f;
	public float timer = 0f;
	float fireTimer = 0f;
	float fireRate = 1.5f;

	public GameObject bullet;

	void Fire() {
		GameObject bullet1 = Instantiate(bullet, this.transform.position, Quaternion.Euler(0f, 0f, 0f));
		bullet1.GetComponent<Bullet>().angle = -90f;
		GameObject bullet2 = Instantiate(bullet, this.transform.position, Quaternion.Euler(0f, 30f, 0f));
		bullet2.GetComponent<Bullet>().angle = -120f;
		GameObject bullet3 = Instantiate(bullet, this.transform.position, Quaternion.Euler(0f, -30f, 0f));
		bullet3.GetComponent<Bullet>().angle = -60f;
	}

	void Start () {
		startPos = this.transform.position;
		
	}

	void Update() {
		if (health <= 0) {
			Destroy(this.gameObject);
		}
		if (fireTimer >= fireRate) {
			fireTimer -= fireRate;
			Fire();
		}
		timer += Time.deltaTime;
		fireTimer += Time.deltaTime;
		this.transform.position = startPos + new Vector3(Mathf.Sin(timer)*10, 0f, -timer*2);
	}
}
