using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Camera MainCamera;

    // scrolling variables
    float minFov = 0.01f;
    float maxFov = 60f;
    float sensitivity = 40f;

    // panning variables
    float panSpeed = 0.5f;
    bool canPanX = true;

    void Start ()
    {
        MainCamera = Camera.main;
	}

	void Update ()
    {
        // scrolling
        float fov = MainCamera.fieldOfView;
        fov += Input.GetAxis("Mouse ScrollWheel") * sensitivity;
        fov = Mathf.Clamp(fov, minFov, maxFov);
        MainCamera.fieldOfView = fov;

        // panning
        if (Input.GetMouseButton(2))
        {
            // check if the camera x is going out of bounds
            if (transform.position.x >= 10 || transform.position.x <= -10)
            {
                // x adjustment
                if (transform.position.x >= 10)
                {
                    transform.position = transform.position + new Vector3(-0.1f, 0, 0);
                }
                if (transform.position.x <= -10)
                {
                    transform.position = transform.position + new Vector3(0.1f, 0, 0);
                }

                canPanX = false;
            }
            else
            {
                canPanX = true;
            }

            if (canPanX == true)
            {
                // pan the camera x
                transform.Translate(Vector3.right * -Input.GetAxis("Mouse X") * panSpeed);
            }
        }

        // check if the user want to quit ('Escape' key)
        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
    }
}
