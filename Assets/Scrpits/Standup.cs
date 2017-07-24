using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Standup : MonoBehaviour {

    bool isHit;
	// Use this for initialization
	void Start () {
        isHit = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "ball" && isHit == false)
        {
            this.transform.up = Vector3.up;
            this.transform.position += new Vector3(0, (GetComponent<Collider>().bounds.size.y / 2)- (GetComponent<Collider>().bounds.size.x/2), 0);
            isHit = true;
        }

       
    }
}
