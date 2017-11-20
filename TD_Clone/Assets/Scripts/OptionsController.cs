using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {

	public Slider volumeSlider;
	public Slider difficultySlider;
	public LevelManager levelManager;
	private MusicManager musicManager;


	// Use this for initialization
	void Start () {

		musicManager = GameObject.FindObjectOfType<MusicManager>(); // jest ze splasha
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
		difficultySlider.value = PlayerPrefsManager.GetDifficulty();


	}
	
	// Update is called once per frame
	void Update () {

		musicManager.SetVolume(volumeSlider.value);
		
	}

	public void SaveAndExit() {

		PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
		levelManager.LoadLevel("01 Start");
		PlayerPrefsManager.SetDifficulty(difficultySlider.value);

	}

	public void SetDefaults() {

		PlayerPrefsManager.SetDifficulty(2);
		difficultySlider.value = 2;
		PlayerPrefsManager.SetMasterVolume(0.5f);
		volumeSlider.value = 0.5f;

	}
}
