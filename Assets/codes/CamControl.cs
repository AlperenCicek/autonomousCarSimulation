using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour {
    public GameObject leftCam;
    public GameObject rightCam;
    public GameObject leftText;
    public GameObject rightText;
    // Use this for initialization
    void Start () {
        rightText.active = true;
        leftText.active = true;
        rightCam.active = false;
        leftCam.active = false;

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonUp(0))
        {
            if(leftCam.active == true)
            {
                leftCam.active = false;
                leftText.active = true;
            }
            else
            {
                leftCam.active = true;
                leftText.active = false;
            }
        }

        if (Input.GetMouseButtonUp(1))
        {
            if (rightCam.active == true)
            {
                rightCam.active = false;
                rightText.active = true;
            }
            else
            {
                rightCam.active = true;
                rightText.active = false;
            }
        }
        /*
        if (Input.GetMouseButton(2))
        {
            Debug.Log("Pressed middle click.");
        }
        */
    }
}
