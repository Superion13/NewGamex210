using UnityEngine;
using System.Collections;

public class des : MonoBehaviour {

	void OnTriggerExit(Collider Other)
	{
		if (Other.tag == "Asteroid") {
			return;
		}
		Destroy(Other.gameObject);
		Destroy (gameObject);
		if (Other.tag == "Enemy") {
			return;
		}
		Destroy(Other.gameObject);
		Destroy (gameObject);
	}
}
