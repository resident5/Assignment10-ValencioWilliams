using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndGame : MonoBehaviour {
	Text GameOverText;
	public Text hud2;


	// Use this for initialization
	void Start () {
		GameOverText = GameObject.Find("GameOver").GetComponent<Text>();
		GameOverText.enabled = false;
	}

	void OnTriggerEnter () {
		GameOverText.enabled = true;
	}
	
	// Update is called once per frame

}
