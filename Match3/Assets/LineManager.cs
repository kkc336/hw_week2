using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LineManager : MonoBehaviour {

	public static LineManager lineManagerScript;

	public List<GameObject> pointTracker;
	public GameObject pointPrefab;
	public int total = 8;

	void Awake(){

		lineManagerScript = this;
	}


	void Start () {
		pointTracker = new List<GameObject> ();

		for(int i = 0; i <total; i++){

			GameObject dot = Instantiate (pointPrefab, transform.position, Quaternion.identity) as GameObject;
			dot.GetComponent<Renderer>().enabled = false;
			pointTracker.Insert (i, dot);
		}
	}
	



	public void SetPoints(Vector3 startPos, Vector3 add){

		for(int i = 0; i < total; i++){
			
			pointTracker [i].transform.position = startPos;
			pointTracker [i].GetComponent<Renderer>().enabled = true;

			startPos = startPos + add;

		}


	}
}
