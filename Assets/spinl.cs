using UnityEngine;
using System.Collections;

public class spinl : MonoBehaviour {
		public float speed = 50f;


		void Update ()
		{
			if (Input.GetKey(KeyCode.E))
				transform.Rotate(Vector2.up, speed * Time.deltaTime);
	}
}
