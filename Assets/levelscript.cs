﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class levelscript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void OnTriggerExit(Collider Other)
	{
		if (Other.tag == "Box") {
			return;
		}
			SceneManager.LoadScene("level2");
	}
}