﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Spaceship : MonoBehaviour {

	public float speed;
	public float shotDelay;
	public GameObject bullet;
	public bool canShot;
	private Animator animator;

	void Start() {
		animator = GetComponent<Animator> ();
	}

	public void Shot(Transform origin) {
		Instantiate (bullet, origin.position, origin.rotation);
	}

	public void Move(Vector2 direction) {
		GetComponent<Rigidbody2D> ().velocity = direction * speed;
	}

	public Animator GetAnimator() {
		return animator;
	}
		
}
