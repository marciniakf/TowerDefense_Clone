using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{

	public AudioClip[] levelMusicChangeArray;

	private AudioSource audiosource;
	private Slider volumeslider;

	void Awake()
	{
		DontDestroyOnLoad(gameObject);
		Debug.Log("Dont destroy on load: " + name);
	}

	void Start()
	{
		audiosource = GetComponent<AudioSource>();
	}

	void OnLevelWasLoaded(int level)
	{

		AudioClip thisLevelMusic = levelMusicChangeArray[level];
		Debug.Log("Playing clip: " + thisLevelMusic);

		if (thisLevelMusic) // jeżeli jest tu muzyka
		{
			audiosource.clip = thisLevelMusic;
			audiosource.loop = true;
			audiosource.Play();

			//volumeslider = GameObject.Find("Volume Slider").GetComponent<Slider>();
			//volumeslider.value = audiosource.volume;

		}
	}

	public void SetVolume(float volume) {

		audiosource.volume = volume;
	}
}
	
	
