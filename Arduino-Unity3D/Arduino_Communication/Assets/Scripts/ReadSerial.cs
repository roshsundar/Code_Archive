using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using UnityEngine;

public class ReadSerial : MonoBehaviour
{
    SerialPort mystream = new SerialPort("COM3", 9600);
    void Start ()
    {
        mystream.ReadTimeout = 50;
        mystream.Open();
    }
	
	void Update ()
    {
        StartCoroutine(AsynchronousReadFromArduino((string s) => Debug.Log(s), () => Debug.Log("Null"), 50f));
	}

    /* Read Function */
    public IEnumerator AsynchronousReadFromArduino(System.Action<string> callback, System.Action fail = null, float timeout = float.PositiveInfinity)
    {
        System.DateTime initialTime = System.DateTime.Now;
        System.DateTime nowTime;
        System.TimeSpan diff = default(System.TimeSpan);

        string dataString = null;

        do
        {
            try
            {
                dataString = mystream.ReadLine();
            }
            catch (System.TimeoutException)
            {
                dataString = null;
            }

            if (dataString != null)
            {
                callback(dataString);
                yield return null;
            }
            else
                yield return new WaitForSeconds(0.05f);

            nowTime = System.DateTime.Now;
            diff = nowTime - initialTime;

        } while (diff.Milliseconds < timeout);

        if (fail != null)
            fail();
        yield return null;
    }
}
