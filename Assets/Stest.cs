using UnityEngine;
using System.Collections;

public class Stest : MonoBehaviour {
	public int health = 20;
	public int damage = 5;

	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter(Collider Enemy){
		health-=damage;
		if (health <= 0) {
			Destroy (gameObject);
		}
	}
	// Update is called once per frame
	void Update () {
	}
}