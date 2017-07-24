using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour {
	public TubeSound o;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerExit(Collider other)
	{
		if (other.tag == "ball")
		{
			Destroy(this.gameObject, 0);
			o.Sound = true;
		}
	}
}
