using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class ChangeMusicVolume : MonoBehaviour {

	public Slider Volume;
	public AudioSource myAudio;
	
	// Update is called once per frame
	void Update () {
		myAudio.volume = Volume.value;

	
	}
}
