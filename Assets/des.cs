using UnityEngine;
using System.Collections;

public class des : MonoBehaviour {
	public int scoreValue;
	public GameController gameController;
	public int health = 20;
	public int damage = 5;

	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <GameController> ();
		}
		if (gameControllerObject == null)
		{
			Debug.Log ("Cannot find GameController script");
		}
	}

	void OnTriggerEnter(Collider Other){
		health-=damage;
		if (health <= 0) {
			Destroy (gameObject);
		gameController.AddScore (scoreValue);
		Destroy(Other.gameObject);
		Destroy (gameObject);
		}
	}
}