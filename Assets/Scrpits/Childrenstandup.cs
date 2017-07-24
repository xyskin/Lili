using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Childrenstandup : MonoBehaviour {
    public GameObject go;
  
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
            for(int i = 0; i < go.transform.childCount; i++)
            {
                stand(i);
            }
            
        }
    }

    void stand(int index)
    {
        Transform child = go.transform.GetChild(index);
        Collider collider = child.GetComponentsInChildren<Collider>()[1];
        child.up = Vector3.up;
        child.position += new Vector3(0, (collider.bounds.size.y / 2) - (collider.bounds.size.x / 2), 0);
        child.GetComponentInChildren<MeshRenderer>().enabled = true;
    }
}
