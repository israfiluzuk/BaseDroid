using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomSpot : MonoBehaviour {

    public GameObject TheBall;
    public float placeX;
    public float placeY;
	// Use this for initialization
	void Start ()
    {
        placeX = Random.Range(-2,2);
        placeY = Random.Range(-4,1);
        TheBall.transform.position = new Vector3(placeX,placeY);
	}
	
	
}
