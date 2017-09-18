using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speed = 5;
	public float lifeTime = 5;
	public int power = 1;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = transform.up.normalized * speed;

		Destroy (gameObject, lifeTime);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnBecameInvisible() {
		Destroy (this.gameObject);
	}

}
