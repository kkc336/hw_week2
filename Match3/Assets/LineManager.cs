using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LineManager : MonoBehaviour {

	public static LineManager lineManagerScript;

	public List<GameObject> pointTracker;
	public GameObject pointPrefab;
	public GameObject dot;
	public int total = 8;

	public bool isRendered = false;

	void Awake(){

		lineManagerScript = this;
	}


	void Start () {
		pointTracker = new List<GameObject> ();

		for(int i = 0; i <total; i++){

			dot = Instantiate (pointPrefab, transform.position, Quaternion.identity) as GameObject;
			dot.GetComponent<Renderer>().enabled = false;
			pointTracker.Insert (i, dot);

		}
	}
	






	void Update(){
		

		if (isRendered == true) {
			//find num
			bool numChack;

			if (MatchManagerScript.matchManager.vNum > MatchManagerScript.matchManager.hNum) {
				for(int i = 0; i < MatchManagerScript.matchManager.vNum; i++){
					pointTracker[i].GetComponent<Renderer>().enabled = true;
				}

			} else {
				for(int i = 0; i < MatchManagerScript.matchManager.hNum; i++){
					pointTracker[i].GetComponent<Renderer>().enabled = true;
				}
			}

		
		} 

		else {
			for(int i = 0; i <total; i++){
			pointTracker[i].GetComponent<Renderer>().enabled = false;
			}
		}
	}





	public void SetPoints(Vector3 startPos, Vector3 add){

		for(int i = 0; i < total; i++){

			//if (i < 3) {
			pointTracker [i].transform.position = startPos + new Vector3(0,0,-1);
				startPos = startPos + add;


		//	} 
		}


	}
}
