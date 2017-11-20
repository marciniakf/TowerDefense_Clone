﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlocked_"; // level_unlocked_1/2/3


	// VOLUME WRAPPER !!
	public static void SetMasterVolume(float volume)
	{

		if (volume >= 0 && volume <= 1)
		{
			PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
		}
		else {
			Debug.LogError("Master volume out of range");
		}
	}

	public static float GetMasterVolume() {
		return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
	}

	//LEVEL UNLOCK WRAPPER !!

	public static void UnlockLevel(int level)
	{
		if (level <= Application.levelCount - 1)
		{
			PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1); // nie ma bools wiec 1 jako prawda dla nas
		}
		else {
			Debug.LogError("Level not in build order");
		}
	}

	public static bool IsLevelUnlocked(int level) {

		int levelValue = PlayerPrefs.GetInt (LEVEL_KEY + level.ToString());
		bool isLevelUnlocked = (levelValue == 1);

		if (level <= Application.levelCount - 1){
			return isLevelUnlocked;
		}
		else { 
				Debug.LogError("Trying to query level not in build order");
			return false;
			}
		}

	// DIFFICULTY WRAPPER !!

	public static void SetDifficulty(float difficulty) {

		if (difficulty >= 1f && difficulty <= 3f)
		{

			PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
		}
		else {
			Debug.LogError("Difficulty out of range");
		}
	}

	public static float GetDifficulty() {
		return PlayerPrefs.GetFloat(DIFFICULTY_KEY);

	}
			
}
