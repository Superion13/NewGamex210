﻿using UnityEngine;
using System.Collections;

public class enemyc : MonoBehaviour {
	public float speed;

	// Use this for initialization
	void Start () {
		speed = 3f;
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 position = transform.position;

		position = new Vector2 (position.x, position.y - speed * Time.deltaTime);

		transform.position = position;

		Vector2 min = Camera.main.ViewportToWorldPoint (new Vector2 (0, 0));

		if (transform.position.y < min.y) {
			Destroy (gameObject);
		}
	
	}
}
