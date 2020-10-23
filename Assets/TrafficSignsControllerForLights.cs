using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficSignsControllerForLights : MonoBehaviour {

	public GameObject redImage;
	public GameObject yellowImage;
	public GameObject greenImage;
	public GameObject trafficLight;
	public bool isItActive;
	// Use this for initialization
	void Start () {

	}
	void FixedUpdate () {
		if (isItActive) 
		{
			if (trafficLight.GetComponent<trafficLight> ().lights [0].active == true) {
				redImage.SetActive (true);
				yellowImage.SetActive (false);
				greenImage.SetActive (false);
			}
			if (trafficLight.GetComponent<trafficLight> ().lights [1].active == true) {
				redImage.SetActive (false);
				yellowImage.SetActive (true);
				greenImage.SetActive (false);
			}
			if (trafficLight.GetComponent<trafficLight> ().lights [2].active == true) {
				redImage.SetActive (false);
				yellowImage.SetActive (false);
				greenImage.SetActive (true);
			}
		
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
			redImage.SetActive (false);
			yellowImage.SetActive (false);
			greenImage.SetActive (false);
		}
	}

}
