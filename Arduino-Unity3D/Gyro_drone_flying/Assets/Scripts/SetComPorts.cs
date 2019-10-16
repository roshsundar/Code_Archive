using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetComPorts : MonoBehaviour
{
    public InputField comTxtFld;
    public Button comBtn;


    DataReader datareaderScript;
    PlaneControl planecontrolScript;

    void Start ()
    {
        comBtn.GetComponent<Button>();
        comTxtFld = comTxtFld.GetComponent<InputField>();

        datareaderScript = GetComponent<DataReader>();
        planecontrolScript = GetComponent<PlaneControl>();

        comBtn.onClick.AddListener(SetComPort);
	}
	
	void Update ()
    {
		
	}

    void SetComPort()
    {
        datareaderScript.comString = comTxtFld.text;
        datareaderScript.enabled = true;
        planecontrolScript.enabled = true;
    }
}
