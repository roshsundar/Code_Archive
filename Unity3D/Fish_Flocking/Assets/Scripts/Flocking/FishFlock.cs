using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishFlock : MonoBehaviour
{
    // Get Refrence to the GlobalFlock script
    GlobalFlock GlobalFlockParentScript;

    // speed variables
    float speed = 0.001f;
    public float minSpeed = 0.8f;
    public float maxSpeed = 2.0f;
    public float rotationSpeed = 4.0f;

    // variables for the 3 rules of a flock
    Vector3 averageHead;
    Vector3 averagePos;
    public float neighborDistance = 3f; // Cutoff point at which fish is no longer part of flock.
    public float tooCloseDistance = 1f; // point at which the fish is too close to another

    // trigger to turn around if it reaches a obstacle and the new target position to turn to
    bool turning = false;
    Vector3 newGoalPos = Vector3.zero;

    /**** Triggered at start of program ****/
    void Start ()
    {
        // set refrence of GlobalFlockParentScript to the fish's parent's GlobalFlock script
        GlobalFlockParentScript = this.transform.parent.GetComponent<GlobalFlock>();

        // Set speed to a random speed for each fish, also set its animation speed to the same value
        speed = Random.Range(minSpeed, maxSpeed);
        this.GetComponent<Animation>()["Motion"].speed = speed;
	}

    /**** Triggered every frame ****/
    void Update ()
    {
        // determine the bounding box of the manager cube
        Bounds b = new Bounds(GlobalFlockParentScript.transform.position, GlobalFlockParentScript.swimLimits);

        // if fish is outside the bounds of the cube, or about to hit something, then start turning around
        RaycastHit hit = new RaycastHit();
        Vector3 direction = Vector3.zero;

        // determine whether to turn or not
        if (!b.Contains(transform.position)) // turn fish to center of area to make it not leave bounds
        {
            turning = true;
            direction = GlobalFlockParentScript.transform.position - this.transform.position;
        }
        else if (Physics.Raycast(this.transform.position, this.transform.forward * 50, out hit)) // turn fish at angle to avoid collision
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
            // calculate the direction from the fish position to the position of the collider and rotate to it
            if (direction != Vector3.zero)
            {
                this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), rotationSpeed * Time.deltaTime);
            }
            // set another random speed for more variation
            speed = Random.Range(minSpeed, maxSpeed);
            this.GetComponent<Animation>()["Motion"].speed = speed;
        }
        else // Apply the flocking rules randomly to get random fish behavior. If they flock too often, up the upper limit
        {
            if (Random.Range(0, 5) < 1)
            {
                ApplyFlockingRules();
            }
        }

        // Move fish forward
        transform.Translate(0, 0, Time.deltaTime * speed);
	}

    /**** Triggered whenever we need to apply flocking behaviour to the fish ****/
    void ApplyFlockingRules()
    {
        // Define a new list to store all the school fish in the parent
        List<GameObject> Fishies = GlobalFlockParentScript.AllFish;

        // Vectors for the center and the avoidance, initialized to 0. Also set a group speed
        Vector3 centerVector = Vector3.zero;
        Vector3 avoidVector = Vector3.zero;
        float groupSpeed = 0.1f;

        // define a target variable to store the goalPos position from the parent
        Vector3 target = GlobalFlockParentScript.goalPos;

        // distance from this fish to another fish, will be used to tell if its within the school range
        float otherFishDistance;

        // the current school size based on who's close enough
        int groupSize = 0;

        // Loop through each fish and adjust this fish's heading based on its neighborDistance and otherFishDistance
        foreach (GameObject otherFish in Fishies)
        {
            if (otherFish != this.gameObject)
            {
                otherFishDistance = Vector3.Distance(otherFish.transform.position, this.transform.position);
                if (otherFishDistance <= neighborDistance)
                {
                    centerVector += otherFish.transform.position; // add up all the other fish's positions
                    groupSize++;

                    if (otherFishDistance < tooCloseDistance)
                    {
                        avoidVector = avoidVector + (this.transform.position - otherFish.transform.position);
                    }

                    FishFlock AnotherFlock = otherFish.GetComponent<FishFlock>();
                    groupSpeed = groupSpeed + AnotherFlock.speed; // add up speeds of all the fish to get school speed
                }
            }
        }

        if (groupSize > 0) // if this fish is in a group...
        {
            // calculate Average center & speed, also set the animation speed to the average speed
            centerVector = centerVector / groupSize + (target - this.transform.position); // calculate the center position
            speed = groupSpeed / groupSize;
            this.GetComponent<Animation>()["Motion"].speed = speed;

            // calcualte the direction which the fish will need to rotate and rotate it
            Vector3 direction = (centerVector + avoidVector) - this.transform.position;
            if (direction != Vector3.zero)
            {
                this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), rotationSpeed * Time.deltaTime);
            }
        }
    }
}
