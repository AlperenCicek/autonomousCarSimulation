﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trafficLight : MonoBehaviour {
	public GameObject[] lights;
	public int i = 0;
	public bool flag = true;
	// Use this for initialization
	void Start () {
		lights[0].active = true;
		lights[1].active = true;
		lights[2].active = true;
		flag = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("p"))
        {
			if(flag)
            {
				flag = false;
            }
            else
            {
				flag = true;
            }
		}
		if(flag)
        {
			if (i <= 444)
			{
				lights[0].active = true;
				lights[1].active = false;
				lights[2].active = false;

			}
			else if (i > 444 && i <= 555)
			{
				lights[0].active = false;
				lights[1].active = true;
				lights[2].active = false;
			}
			else if (i > 555 && i < 1500)
			{
				lights[0].active = false;
				lights[1].active = false;
				lights[2].active = true;
			}
			else if (i > 1500)
			{
				i = 0;
				flag = false;
			}
			i++;
		}
		
		
       
		
	}
}
