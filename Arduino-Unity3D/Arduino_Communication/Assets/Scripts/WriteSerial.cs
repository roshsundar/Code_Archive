using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using UnityEngine;

public class WriteSerial : MonoBehaviour
{
    SerialPort stream = new SerialPort("COM3", 9600);
	void Start ()
    {
        stream.ReadTimeout = 50;
        stream.Open();

        WriteToArduino("PING");
	}
	
	void Update ()
    {
		
	}

    // Write Funtion
    public void WriteToArduino(string message)
    {
        stream.WriteLine(message);
        stream.BaseStream.Flush();
    }
}
