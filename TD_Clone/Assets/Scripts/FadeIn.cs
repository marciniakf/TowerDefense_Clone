using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {

	public float FadeInTime;

	private Image fadePanel;
	private Color currentColor = Color.black;



	void Start () {
		fadePanel = GetComponent<Image>();
		
	}
	

	void Update () {
		if (Time.timeSinceLevelLoad < FadeInTime) {

			float AlphaChange = Time.deltaTime / FadeInTime;
			currentColor.a -= AlphaChange;
			fadePanel.color = currentColor;
		}
		else {
			gameObject.SetActive(false);
		}
	}
}
