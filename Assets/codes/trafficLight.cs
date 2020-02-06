using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trafficLight : MonoBehaviour {
	public GameObject[] lights;
	public int i = 0;
	// Use this for initialization
	void Start () {
		lights[0].active = true;
		lights[1].active = true;
		lights[2].active = true;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(i <= 444)
        {
			lights[0].active = true;
			lights[1].active = false;
			lights[2].active = false;

		}
		else if(i > 444 && i <= 555)
        {
			lights[0].active = false;
			lights[1].active = true;
			lights[2].active = false;
		}
		else if(i > 555 && i < 1000)
        {
			lights[0].active = false;
			lights[1].active = false;
			lights[2].active = true;
		}
		else if(i > 1000)
        {
			i = 0;
        }
		i++;
		
       
		
	}
}
