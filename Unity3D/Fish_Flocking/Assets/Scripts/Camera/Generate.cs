using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
	void Start ()
    {
        // Initialize fog
        RenderSettings.fogColor = Camera.main.backgroundColor;
        RenderSettings.fogDensity = 0.04f;
        RenderSettings.fog = true;
	}
}
