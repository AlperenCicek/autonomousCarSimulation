using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficSignsController : MonoBehaviour {

	public GameObject greenImage;
	public GameObject redImage;
	public bool isItActive;
	// Use this for initialization
	void Start () {
		redImage.SetActive (true);
	}
	void Update () {
		if (isItActive) {
			redImage.SetActive (false);
			greenImage.SetActive (true);
		}
			
	}	
	void OnTriggerStay(Collider col)
	{
		if(col.gameObject.tag == "Player")
		{
			isItActive = true;
		}
	}
	void OnTriggerExit(Collider col)
	{
		if(col.gameObject.tag == "Player")
		{
			isItActive = false;
			redImage.SetActive (true);
			greenImage.SetActive (false);
		}
	}

}
