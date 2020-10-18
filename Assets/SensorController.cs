using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnTriggerStay(Collider col)
	{
		if(col.gameObject.tag == "Untagged")
			Debug.Log("Çarptın");
	}
}
