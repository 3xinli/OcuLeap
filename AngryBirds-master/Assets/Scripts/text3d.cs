using UnityEngine;
using Assets.Scripts;
using System.Collections;
//using Enums;

public class text3d : MonoBehaviour {

	int counter = 0;
	TextMesh text;
	// Use this for initialization
	void Start () {
		text = gameObject.GetComponent ("TextMesh") as TextMesh;
	}
	
	// Update is called once per frame
	void Update () {
		GUIStyle style = new GUIStyle ();
		style.fontSize = 30;
		style.normal.textColor = Color.white;
		switch (GameManager.CurrentGameState)
		{
		case GameState.Start:
			text.text= "Swipe hand down to start";
			break;
		case GameState.Won:
			text.text= "You won! Swipe hand down to restart";
			break;
		case GameState.Lost:
			text.text= "You lost! Swipe hand down to restart";
			break;
		default:
			switch (GameManager.ss) {
			case SlingshotState.Idle:
				text.text= "Swipe hand down to ready your bird!";
				break;
			case SlingshotState.UserPulling:
				text.text="Swipe hand up and down to adjust your aim\n When ready, swipe hand horizonally to shoot!";
				break;
			default:
				break;
			}
			break;
		}
	}
}
