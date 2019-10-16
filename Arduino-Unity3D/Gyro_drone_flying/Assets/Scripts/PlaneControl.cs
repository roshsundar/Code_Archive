using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneControl : MonoBehaviour
{
    public string inputData;

    public int speed;

    Rigidbody myrigidbody;
	void Start ()
    {
        myrigidbody = GetComponent<Rigidbody>();
	}
	
	void Update ()
    {
        string[] values = inputData.Split(',');
        float TiltX = float.Parse(values[0]);
        float TiltY = float.Parse(values[1]);
        float TiltZ = float.Parse(values[2]);

        transform.localEulerAngles = new Vector3(TiltX, 0, -TiltY);
    }

    void FixedUpdate()
    {
        transform.TransformDirection(Vector3.forward);
        myrigidbody.AddForce(-transform.forward * speed);
    }
}
