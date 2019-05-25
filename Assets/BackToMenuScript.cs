using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class BackToMenuScript : MonoBehaviour {

	int sceneIndex;
	// Use this for initialization
	void Start () {
		sceneIndex = SceneManager.GetActiveScene ().buildIndex;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {

			SceneManager.LoadScene (sceneIndex-1);
		}

	
	}
}
