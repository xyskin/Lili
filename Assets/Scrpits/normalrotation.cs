using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normalrotation : MonoBehaviour {
    public Vector3 eulerang;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void reset()
    {
        this.transform.eulerAngles = eulerang;
    }
    public void set()
    {
        eulerang = this.transform.eulerAngles;
    }
}
