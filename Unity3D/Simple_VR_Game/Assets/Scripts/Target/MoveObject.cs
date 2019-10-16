using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public Transform SpawnArea;

    bool isRunning = false;
    void Start()
    {
        ShowCube();
    }

    void Update ()
    {
        if (isRunning == false)
        {
            StartCoroutine(ExecuteAfterDelay(Random.Range(3, 5)));
            isRunning = true;
        }
    }

    IEnumerator ExecuteAfterDelay(int secs)
    {
        yield return new WaitForSeconds(secs);
        Chances();
        isRunning = false;
    }

    void Chances()
    {
        int changeChance = Random.Range(0, 100); // chance of the current status of the cube changing
        if (changeChance <= 50)
        {
            int visChance = Random.Range(1, 100); // chance of the cube being hidden or visible
            if (visChance <= 15)
            {
                HideCube();
            }
            else
            {
                ShowCube();
            }
        }
    }

    public void ShowCube()
    {
        Vector3 spawnAreaPos = SpawnArea.position;
        float xDiff = (SpawnArea.GetComponent<BoxCollider>().size.x) / 2;
        float yDiff = (SpawnArea.GetComponent<BoxCollider>().size.y) / 2;
        float zDiff = (SpawnArea.GetComponent<BoxCollider>().size.z) / 2;

        Vector3 newPos = new Vector3(spawnAreaPos.x + Random.Range(-xDiff, xDiff), 
            spawnAreaPos.y + Random.Range(-yDiff, yDiff),
            spawnAreaPos.z + Random.Range(-zDiff, zDiff));

        transform.position = newPos;
    }

    public void HideCube()
    {
        transform.position = new Vector3(10, 10, 10);
    }
}
