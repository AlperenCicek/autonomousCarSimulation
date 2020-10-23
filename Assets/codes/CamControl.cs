using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour {
    public GameObject leftText;
	public GameObject rightText;
	public GameObject leftBlock;
	public GameObject rightBlock;
    // Use this for initialization
    void Start () {
        rightText.active = false;
        leftText.active = false;
		rightBlock.active = true;
		leftBlock.active = true;

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonUp(0))
        {
			if(leftBlock.active == true)
            {
				leftBlock.active = false;
				//leftText.active = true;
            }
            else
            {
				leftBlock.active = true;
				//leftText.active = false;
            }
        }

        if (Input.GetMouseButtonUp(1))
        {
			if (rightBlock.active == true)
            {
				rightBlock.active = false;
				//rightText.active = true;
            }
            else
            {
				rightBlock.active = true;
                //rightText.active = false;
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
