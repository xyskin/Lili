using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounde : MonoBehaviour {
	public TubeSound o;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "ball")
		{
			Destroy(this.gameObject, 0);
			o.Sound = false;
		}
	}
}
