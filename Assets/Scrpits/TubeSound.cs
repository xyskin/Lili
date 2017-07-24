using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TubeSound : MonoBehaviour {
	public bool Sound;
	public AudioSource audio;
	public Image image;
	// Use this for initialization
	void Start () {
		Sound = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Sound == true && !audio.isPlaying)
		{
			Debug.Log("sound out");
			image.color = new Color(0, 0, 0, 1);
			audio.Play();
		}
		if (Sound == false && audio.isPlaying)
		{
			Debug.Log("sound end");
			image.color = new Color(0, 0, 0, 0);
			audio.Stop();
		}
	}
}
