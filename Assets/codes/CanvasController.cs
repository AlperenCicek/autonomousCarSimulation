using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour {
	public GameObject car;
	public GameObject leftBlock;
	public GameObject rightBlock;
	public GameObject green_left;
	public GameObject green_right;
	public GameObject green_forward;
	public GameObject green_front_left;
	public GameObject green_front_right;
	public GameObject red_left;
	public GameObject red_right;
	public GameObject red_forward;
	public GameObject red_front_left;
	public GameObject red_front_right;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		car.transform.position = new Vector2(Screen.width * 4.6f / 8, Screen.height * 3.6f / 4);
		car.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		car.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);
		leftBlock.transform.position = new Vector2(Screen.width * 1.4f / 8, Screen.height * 3.795f / 4);
		leftBlock.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 3.9f);
		leftBlock.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 4.5f);
		rightBlock.transform.position = new Vector2(Screen.width * 6.6f / 8, Screen.height * 3.795f / 4);
		rightBlock.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 3.9f);
		rightBlock.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 4.5f);
		green_forward.transform.position = new Vector2(Screen.width * 4.6f / 8, Screen.height * 3.85f / 4);
		green_forward.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		green_forward.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);
		red_forward.transform.position = new Vector2(Screen.width * 4.6f / 8, Screen.height * 3.85f / 4);
		red_forward.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		red_forward.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);
		green_front_left.transform.position = new Vector2(Screen.width * 4.4f / 8, Screen.height * 3.75f / 4);
		green_front_left.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		green_front_left.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);
		red_front_left.transform.position = new Vector2(Screen.width * 4.4f / 8, Screen.height * 3.75f / 4);
		red_front_left.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		red_front_left.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);
		green_front_right.transform.position = new Vector2(Screen.width * 4.8f / 8, Screen.height * 3.75f / 4);
		green_front_right.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		green_front_right.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);
		red_front_right.transform.position = new Vector2(Screen.width * 4.8f / 8, Screen.height * 3.75f / 4);
		red_front_right.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		red_front_right.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);
		green_left.transform.position = new Vector2(Screen.width * 4.3f / 8, Screen.height * 3.50f / 4);
		green_left.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		green_left.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);
		red_left.transform.position = new Vector2(Screen.width * 4.3f / 8, Screen.height * 3.50f / 4);
		red_left.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		red_left.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);
		green_right.transform.position = new Vector2(Screen.width * 4.9f / 8, Screen.height * 3.50f / 4);
		green_right.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		green_right.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);
		red_right.transform.position = new Vector2(Screen.width * 4.9f / 8, Screen.height * 3.50f / 4);
		red_right.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		red_right.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);
	}
}
