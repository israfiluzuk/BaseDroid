using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class floor : MonoBehaviour {
	public AudioClip[] sounds;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Ball")
        {
            collision.transform.GetComponent<NewBehaviourScript>().hoolCollider = false;
            collision.transform.GetComponent<NewBehaviourScript>().wasFired = false;
            collision.transform.GetComponent<SpriteRenderer>().sortingOrder = 3;
			GetComponent<AudioSource> ().PlayOneShot (sounds[1]);
        }
    }
}
