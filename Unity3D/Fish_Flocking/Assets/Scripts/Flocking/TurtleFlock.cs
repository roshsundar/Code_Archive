using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleFlock : MonoBehaviour {

    // Get Refrence to the GlobalFlock script
    GlobalFlock GlobalFlockParentScript;

    // speed variables
    float speed = 0.001f;
    public float minSpeed = 0.8f;
    public float maxSpeed = 2.0f;
    float rotationSpeed = 4.0f;

    // trigger to turn around if it reaches a obstacle
    bool turning = false;

    /**** Triggered at start of program ****/
    void Start()
    {
        // set refrence of GlobalFlockParentScript to the turtle's parent's GlobalFlock script
        GlobalFlockParentScript = this.transform.parent.GetComponent<GlobalFlock>();

        // Set speed to a random speed for each turtle, also set its animation speed to the same value
        speed = Random.Range(minSpeed, maxSpeed);
    }

    /**** Triggered every frame ****/
    void Update()
    {
        // determine the bounding box of the manager cube
        Bounds b = new Bounds(GlobalFlockParentScript.transform.position, GlobalFlockParentScript.swimLimits);

        // if turtle is outside the bounds of the cube, or about to hit something, then start turning around
        RaycastHit hit = new RaycastHit();
        Vector3 direction = Vector3.zero;

        if (!b.Contains(transform.position)) // turn turtle to goalpos to make it not leave bounds
        {
            turning = true;
            direction = GlobalFlockParentScript.goalPos - this.transform.position;
        }
        else if (Physics.Raycast(this.transform.position, this.transform.forward * 50, out hit)) // turn turtle at angle to avoid collision
        {
            turning = true;
            direction = Vector3.Reflect(this.transform.forward, hit.normal);
        }
        else
        {
            turning = false;
        }

        // do the actions for either turning or not turning
        if (turning) // if turning = true, then actually turn...
        {
            // calculate the direction from the turtle position to the position of the collider and rotate to it
            if (direction != Vector3.zero)
            {
                this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), rotationSpeed * Time.deltaTime);
            }
            // set another random speed for more variation
            speed = Random.Range(minSpeed, maxSpeed);
        }

        // Move turtle forward
        transform.Translate(0, 0, Time.deltaTime * speed);
    }
}
