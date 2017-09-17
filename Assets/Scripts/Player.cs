using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	Spaceship spaceship;
	 
	// Use this for initialization
	IEnumerator Start () {
		spaceship = GetComponent<Spaceship> ();
		while (true) {
			spaceship.Shot (transform);
			GetComponent<AudioSource> ().Play ();
			yield return new WaitForSeconds (spaceship.shotDelay);
		}
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
	}

	void Move() {
		// 右・左
		float x = Input.GetAxisRaw ("Horizontal");

		// 上・下
		float y = Input.GetAxisRaw ("Vertical");

		// 移動する向きを求める
		Vector2 direction = new Vector2 (x, y).normalized;

		spaceship.Move(direction);
	}

	void OnTriggerEnter2D(Collider2D collider) {
		string layerName = LayerMask.LayerToName (collider.gameObject.layer);
		if (layerName == "BulletEnemy") {
			Destroy (collider.gameObject);
		}
		if (layerName == "Enemy" || layerName == "BulletEnemy") {
			FindObjectOfType<Manager> ().GameOver ();
			Destroy (gameObject);
		}
	}
}
