using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    int _score;
    public static GameManager instance;
    public Text scoreText;
    public int score
    {
        get
        {
            return _score;
        }set
        {
            _score = value;
            scoreText.text = "Score: "+ _score.ToString();

        }
    }
	// Use this for initialization
	void Start () {
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
