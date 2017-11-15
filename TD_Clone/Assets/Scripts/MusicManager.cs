using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{

	public AudioClip[] levelMusicChangeArray;

	private AudioSource audiosource;

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
		}
	}
}
	
	
