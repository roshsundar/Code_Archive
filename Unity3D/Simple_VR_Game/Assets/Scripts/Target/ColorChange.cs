using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    List<Color> Colors = new List<Color>();
    int CurrentIndex = 0;

    public Material ThisMaterial;

    void Start()
    {
        // Color pallete
        Colors.Add(Color.red);
        Colors.Add(Color.magenta);
        Colors.Add(Color.green);
        Colors.Add(Color.grey);
        Colors.Add(Color.cyan);
        Colors.Add(Color.yellow);
        Colors.Add(Color.blue);

        ThisMaterial.color = Colors[CurrentIndex]; // Initial Color
    }

    public void ChangeColor()
    {
        ThisMaterial.color = Colors[CurrentIndex];

        CurrentIndex++;

        if (CurrentIndex == Colors.Count)
        {
            CurrentIndex = 0;
        }
    }
}
