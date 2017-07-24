using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Childrenstandupqq : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void stand()
    {
        this.transform.up = Vector3.up;
        this.transform.position += new Vector3(0, (GetComponent<Collider>().bounds.size.y / 2) - (GetComponent<Collider>().bounds.size.x / 2), 0);
    }
}
