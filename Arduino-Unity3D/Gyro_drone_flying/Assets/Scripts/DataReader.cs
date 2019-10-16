using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using UnityEngine;

public class DataReader : MonoBehaviour {

    public string comString;

    SerialPort mystream;

    PlaneControl planecontrolScript;

    void Start()
    {
        mystream = new SerialPort(comString, 115200);

        mystream.ReadTimeout = 50;
        mystream.Open();

        planecontrolScript = GetComponent<PlaneControl>();
    }

    void Update()
    {
        int i;
        StartCoroutine(AsynchronousReadFromArduino((string s) => planecontrolScript.inputData = s, () => i = 1, 50f));
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
