using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

    Vector2 startpos, endpos, direction;
    float touchTimeStart, touchTimeFinish, timeInterval; //Calculating swipe time

    [Range(0.05f, 1f)]               //slider for inspector window
    public float throwForse = 0.4f;  //for controlling throw forse
    Vector2 mousePos;

    bool wasPressed = false;
    float lastPosY = -999f;
    public bool wasFired;
    public Collider2D leftHool, rightHool;
    public Text state;
    bool _hoolCollider;
    public bool hoolCollider
    {
        get
        {
            return _hoolCollider;
        }
        set
        {
            if(value == true)
            {
                _hoolCollider = true;
                leftHool.enabled = true;
                rightHool.enabled = true;
            }
            else
            {
                _hoolCollider = false;
                leftHool.enabled = false;
                rightHool.enabled = false;
            }
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) 
        {
            touchTimeStart = Time.time;
            startpos = Input.GetTouch(0).position;

		}

        if(Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            touchTimeFinish = Time.time;

            timeInterval = touchTimeFinish - touchTimeStart;

            endpos = Input.GetTouch(0).position;

            direction = startpos - endpos;

            direction = startpos - endpos;

            GetComponent<Rigidbody2D>().AddForce(-direction/timeInterval*throwForse);
            wasFired = true;
        }

        if (wasFired)
        {
            if(lastPosY > transform.position.y)
            {
                hoolCollider = true;
            }
            lastPosY = transform.position.y;
        }

        //if (Input.GetMouseButtonDown(0) && Input.GetMouseButtonDown(0).phase == TouchPhase.Began)
        //{
        //    mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    if(wasPressed == false)
        //    {
        //        startpos = mousePos;
        //        touchTimeStart = Time.time;
        //        wasPressed = true;
        //    }
        //    transform.position = mousePos;
            
            
        //}
        //if (Input.GetMouseButtonUp(0) && Input.GetTouch(0).phase == TouchPhase.Ended)
        //{
        //    wasPressed = false;
        //    touchTimeFinish = Time.time;

        //    timeInterval = touchTimeFinish - touchTimeStart;
        //    mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    endpos = mousePos;

        //    direction = startpos - endpos;

        //    GetComponent<Rigidbody2D>().AddForce(-direction / timeInterval * throwForse);
        //}

    }
}
