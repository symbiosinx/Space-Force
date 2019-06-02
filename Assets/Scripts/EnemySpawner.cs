using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemyPrefab;
	float timer = 0f;
	float fireRate = 2f;

	void Start () {
		
	}
	
	void Update () {
		timer += Time.deltaTime;
		fireRate = Mathf.Sin(0.25f * timer) + 2f;
		if (timer >= fireRate) {
			timer -= fireRate;
			float randomZ = Random.Range(0f, 7f);
			GameObject clone = Instantiate(enemyPrefab, new Vector3(0f, 0f, 23f + randomZ), Quaternion.identity);
			clone.GetComponent<Enemy>().timer += randomZ;
		}
	}
}
