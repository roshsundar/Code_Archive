using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalFlock : MonoBehaviour
{
   /* FISH BEHAVIOR LIBRARY
   * TightKnit - small tooCloseDistance, larger rotationSpeed
   * More spaced - larger tooCloseDistance, lower rotationSpeed
   * Flock Often - up the chance factor
   * Flock Less - lower the chance factor
   * With the current setup, 300 fish is the best upper limit. Don't risk going over 500.
   * With current setup, can use largest graphic setting (1920x1080) in the build if you set graphics quality to 'fastest'
   * For turtles: set the chance limit higher (200). Also, set one turtle for every globalflock script
   */

    // prefab of the specic fish
    public GameObject fishPrefab;

    // half the length of the BOX tank
    public int tankRad = 5;

    // the number of fish to be generated
    public int numFish = 10;

    // List containing all fish for the school
    public List<GameObject> AllFish = new List<GameObject>();

    // create a goal position for the school to work to
    public Vector3 goalPos = Vector3.zero;

    // The area in which the fish can swim
    public Vector3 swimLimits = new Vector3(10, 4, 10);

    // The threshold chance for when the goal pos will change
    public int chanceFactor = 50;

    /**** Triggered at start of program ****/
    void Start ()
    {
        // Generate fish at random position
        for (int i = 0; i < numFish; i++)
        {
            // set a random position for the fish.
            Vector3 pos = new Vector3(Random.Range(transform.position.x - swimLimits.x, transform.position.x + swimLimits.x), Random.Range(transform.position.y - swimLimits.y, transform.position.y + swimLimits.y), Random.Range(transform.position.z - swimLimits.z, transform.position.z + swimLimits.z));

            // instantiate the fish at the position, add it to AllFish, and child it to the specific script that created it
            AllFish.Add(Instantiate(fishPrefab, pos, Quaternion.identity));
            AllFish[i].transform.SetParent(this.transform);
        }

        goalPos = this.transform.position;
    }

    /**** Triggered every frame ****/
    void Update ()
    {
		// set goalpos to random position oh so often within tank bounds.if changes too much, up upper limit. if changes too little, lower upper limit 
        if (Random.Range(0, 10000) < chanceFactor)
        {
            goalPos = new Vector3(Random.Range(transform.position.x - swimLimits.x, transform.position.x + swimLimits.x), Random.Range(transform.position.y - swimLimits.y, transform.position.y + swimLimits.y), Random.Range(transform.position.z - swimLimits.z, transform.position.z + swimLimits.z));
        }
	}

    /**** Display both the goal position and the bounding limits of the box ****/
    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5F);
        Gizmos.DrawCube(transform.position, new Vector3(swimLimits.x * 2, swimLimits.y * 2, swimLimits.z * 2));
        Gizmos.color = new Color(0, 1, 0, 1);
        Gizmos.DrawSphere(goalPos, 0.1f);
    }
}
