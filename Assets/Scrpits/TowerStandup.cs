using System.Collections;
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
            this.transform.position = new Vector3(-90.69019f, 137.7208f, 80.24561f);
        }

    }
}
