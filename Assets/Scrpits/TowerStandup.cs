﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerStandup : MonoBehaviour {

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
            this.transform.up = Vector3.up;
            this.transform.right = Vector3.forward;
        }

    }
}
