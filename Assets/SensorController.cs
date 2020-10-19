using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorController : MonoBehaviour {
	public bool isItActive;
	public GameObject image;
	public float distance;
	public GameObject redImage;
	public bool isItRed;
	// Use this for initialization
	void Start () {
		image.SetActive (false);
		isItActive = false;
	}
	
	// Update is called once per frame

	/*
	void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "Untagged") {
			isItActive = false;	
			Debug.Log ("dfssdf");
		}
	}*/
	void FixedUpdate () 
	{
		if (isItRed == false) {

			if (isItActive && redImage.active == false)
				image.SetActive (true);
			else
				image.SetActive (false);		
		} else {
			if (isItActive)
				image.SetActive (true);
			else
				image.SetActive (false);	
		}
		isItActive = false;
		//print (distance);

	}

	void OnTriggerStay(Collider col)
	{
		//distance = Vector3.Distance (col.transform.position, transform.position);
		isItActive = true;
	}


}
