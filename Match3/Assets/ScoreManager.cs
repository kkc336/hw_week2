using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public static ScoreManager scoreManager;

	public Text scoreDisplay;

	public int score;

	void Awake(){
	//anyone can access the script
		scoreManager = this;
	
	}


	void Start () {
		//begins with 0
		score = 0;
		//display number
		scoreDisplay.text = score.ToString ();
	}
	

	void Update () {
		scoreDisplay.text = score.ToString ();
	}



	

}
