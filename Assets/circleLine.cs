using UnityEngine;
using System.Collections;

public class circleLine : MonoBehaviour {
	public AudioClip[] sounds;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Ball")
        {
            if (collision.transform.GetComponent<NewBehaviourScript>().hoolCollider)
            {
                GameManager.instance.score++;
				GetComponent<AudioSource> ().PlayOneShot (sounds[0]);
                collision.transform.GetComponent<SpriteRenderer>().sortingOrder = 1;
            }
           
        }
    }
    
}
