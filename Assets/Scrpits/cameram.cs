using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameram : MonoBehaviour {
    public GameObject ball;
    float dis = -10.0f;
	// Use this for initialization
	void Start () {
        
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            float mousX = Input.GetAxis("Mouse X") * 20;
            Camera.main.transform.RotateAround(ball.transform.position, Vector3.up, mousX);
            
        }
        if (Input.GetMouseButton(1))
        {
            float mousY = Input.GetAxis("Mouse Y") * 20;
            if(Camera.main.transform.eulerAngles.x+ mousY < 70&& Camera.main.transform.eulerAngles.x+ mousY > 10)
                Camera.main.transform.RotateAround(ball.transform.position, Camera.main.transform.right, mousY);
        }
        
        if (Input.GetAxis("Mouse ScrollWheel")>0)
        {
            dis += 0.3f;
            
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            dis -= 0.3f;
        }
        clamp(-10.0f, -1.0f, ref dis);
        Camera.main.transform.LookAt(ball.transform.position);
        Camera.main.transform.position=Camera.main.transform.forward*dis+ball.transform.position;
    }

    void clamp( float min,float max,ref float value)
    {
        value= value> max?max:(value<min? min:value);
    }
}
