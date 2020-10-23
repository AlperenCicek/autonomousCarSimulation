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
	public GameObject traffic_light;
	public GameObject green_traffic_light;
	public GameObject yellow_traffic_light;
	public GameObject red_traffic_light;
	public GameObject not_left_turn;
	public GameObject green_not_left_turn;
	public GameObject red_not_left_turn;
	public GameObject stop;
	public GameObject green_stop;
	public GameObject red_stop;
	public GameObject not_turn_right;
	public GameObject green_not_turn_right;
	public GameObject red_not_turn_right;
	public GameObject left_and_straight;
	public GameObject green_left_and_straight;
	public GameObject red_left_and_straight;
	public GameObject right_and_straight;
	public GameObject green_right_and_straight;
	public GameObject red_right_and_straight;
	public GameObject turn_left;
	public GameObject green_turn_left;
	public GameObject red_turn_left;
	public GameObject turn_right;
	public GameObject green_turn_right;
	public GameObject red_turn_right;
	public GameObject close;
	public GameObject green_close;
	public GameObject red_close;
	public GameObject passenger_in;
	public GameObject green_passenger_in;
	public GameObject red_passenger_in;
	public GameObject passenger_out;
	public GameObject green_passenger_out;
	public GameObject red_passenger_out;


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

		not_left_turn.transform.position = new Vector2(Screen.width * 1.5f / 8, Screen.height * 0.25f / 4);
		not_left_turn.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		not_left_turn.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);

		green_not_left_turn.transform.position = new Vector2(Screen.width * 1.75f / 8, Screen.height * 0.25f / 4);
		green_not_left_turn.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		green_not_left_turn.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);

		red_not_left_turn.transform.position = new Vector2(Screen.width * 1.75f / 8, Screen.height * 0.25f / 4);
		red_not_left_turn.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		red_not_left_turn.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);

		not_turn_right.transform.position = new Vector2(Screen.width * 2f / 8, Screen.height * 0.25f / 4);
		not_turn_right.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		not_turn_right.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);

		green_not_turn_right.transform.position = new Vector2(Screen.width * 2.25f / 8, Screen.height * 0.25f / 4);
		green_not_turn_right.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		green_not_turn_right.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);

		red_not_turn_right.transform.position = new Vector2(Screen.width * 2.25f / 8, Screen.height * 0.25f / 4);
		red_not_turn_right.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		red_not_turn_right.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);
		
		left_and_straight.transform.position = new Vector2(Screen.width * 2.5f / 8, Screen.height * 0.25f / 4);
		left_and_straight.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		left_and_straight.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);

		green_left_and_straight.transform.position = new Vector2(Screen.width * 2.75f / 8, Screen.height * 0.25f / 4);
		green_left_and_straight.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		green_left_and_straight.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);

		red_left_and_straight.transform.position = new Vector2(Screen.width * 2.75f / 8, Screen.height * 0.25f / 4);
		red_left_and_straight.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		red_left_and_straight.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);

		right_and_straight.transform.position = new Vector2(Screen.width * 3f / 8, Screen.height * 0.25f / 4);
		right_and_straight.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		right_and_straight.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);

		green_right_and_straight.transform.position = new Vector2(Screen.width * 3.25f / 8, Screen.height * 0.25f / 4);
		green_right_and_straight.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		green_right_and_straight.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);

		red_right_and_straight.transform.position = new Vector2(Screen.width * 3.25f / 8, Screen.height * 0.25f / 4);
		red_right_and_straight.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		red_right_and_straight.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);

		turn_left.transform.position = new Vector2(Screen.width * 3.5f / 8, Screen.height * 0.25f / 4);
		turn_left.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		turn_left.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);

		green_turn_left.transform.position = new Vector2(Screen.width * 3.75f / 8, Screen.height * 0.25f / 4);
		green_turn_left.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		green_turn_left.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);

		red_turn_left.transform.position = new Vector2(Screen.width * 3.75f / 8, Screen.height * 0.25f / 4);
		red_turn_left.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		red_turn_left.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);
		
		turn_right.transform.position = new Vector2(Screen.width * 4f / 8, Screen.height * 0.25f / 4);
		turn_right.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		turn_right.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);

		green_turn_right.transform.position = new Vector2(Screen.width * 4.25f / 8, Screen.height * 0.25f / 4);
		green_turn_right.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		green_turn_right.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);

		red_turn_right.transform.position = new Vector2(Screen.width * 4.25f / 8, Screen.height * 0.25f / 4);
		red_turn_right.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		red_turn_right.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);	

		close.transform.position = new Vector2(Screen.width * 4.5f / 8, Screen.height * 0.25f / 4);
		close.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		close.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);

		green_close.transform.position = new Vector2(Screen.width * 4.75f / 8, Screen.height * 0.25f / 4);
		green_close.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		green_close.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);

		red_close.transform.position = new Vector2(Screen.width * 4.75f / 8, Screen.height * 0.25f / 4);
		red_close.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		red_close.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);
		
		passenger_in.transform.position = new Vector2(Screen.width * 5f / 8, Screen.height * 0.25f / 4);
		passenger_in.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		passenger_in.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);

		green_passenger_in.transform.position = new Vector2(Screen.width * 5.25f / 8, Screen.height * 0.25f / 4);
		green_passenger_in.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		green_passenger_in.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);

		red_passenger_in.transform.position = new Vector2(Screen.width * 5.25f / 8, Screen.height * 0.25f / 4);
		red_passenger_in.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		red_passenger_in.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);
		
		passenger_out.transform.position = new Vector2(Screen.width * 5.5f / 8, Screen.height * 0.25f / 4);
		passenger_out.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		passenger_out.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);

		green_passenger_out.transform.position = new Vector2(Screen.width * 5.75f / 8, Screen.height * 0.25f / 4);
		green_passenger_out.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		green_passenger_out.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);

		red_passenger_out.transform.position = new Vector2(Screen.width * 5.75f / 8, Screen.height * 0.25f / 4);
		red_passenger_out.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		red_passenger_out.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);
		
		traffic_light.transform.position = new Vector2(Screen.width * 6f / 8, Screen.height * 0.25f / 4);
		traffic_light.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		traffic_light.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);
		
		green_traffic_light.transform.position = new Vector2(Screen.width * 6.25f / 8, Screen.height * 0.25f / 4);
		green_traffic_light.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		green_traffic_light.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);

		yellow_traffic_light.transform.position = new Vector2(Screen.width * 6.25f / 8, Screen.height * 0.25f / 4);
		yellow_traffic_light.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		yellow_traffic_light.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);

		red_traffic_light.transform.position = new Vector2(Screen.width * 6.25f / 8, Screen.height * 0.25f / 4);
		red_traffic_light.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		red_traffic_light.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);
		
		stop.transform.position = new Vector2(Screen.width * 6.5f / 8, Screen.height * 0.25f / 4);
		stop.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		stop.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);

		green_stop.transform.position = new Vector2(Screen.width * 6.75f / 8, Screen.height * 0.25f / 4);
		green_stop.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		green_stop.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);

		red_stop.transform.position = new Vector2(Screen.width * 6.75f / 8, Screen.height * 0.25f / 4);
		red_stop.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width / 11);
		red_stop.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.width / 11);
	}
}
