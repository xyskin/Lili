using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushdis : MonoBehaviour {

    public GameObject mush;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ball") Destroy(mush.gameObject, 0);
    }
}

