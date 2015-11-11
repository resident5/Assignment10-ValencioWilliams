using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

public class GameController : MonoBehaviour {
	Text hudText;
	Text gameOverUI;

	public GameObject player;

	public float timeInGame;


	public Text hud;
	public Text hud2;

	//The amount of ellapsed time
	private float time = 0;

	//Flag that control the state of the game
	private bool isRunning = false;
	
	// Use this for initialization
	void Awake(){
		if (PlayerPrefs.HasKey ("score")) {
			RestorePlayerValues ();
		} else {
			StartNewGame ();
		}

	}

	void Start () {
		hudText = GameObject.Find("HUDText").GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update () {
		string hudInfo = "";
		
		timeInGame += Time.deltaTime;
		hudInfo += "Time: " + timeInGame.ToString ("F2");
		hudText.text = hudInfo;


		time += Time.deltaTime;
		hud.text = "Time: " + (int)time;


	}

	public void StartNewGame() {
		if (PlayerPrefs.HasKey ("score")) {
			DeletePlayerValues();
		}
		timeInGame = 0;
		StorePlayerValues ();
	}

	public void Stop() {
			gameOverUI.enabled = true;
	}

	void StorePlayerValues() {
		PlayerPrefs.SetFloat ("timeInGame", timeInGame);
	}

	void RestorePlayerValues() {
		timeInGame = PlayerPrefs.GetFloat ("timeInGame");
	}

	public void DeletePlayerValues() {
		PlayerPrefs.DeleteKey ("timeInGame");
	}
}
