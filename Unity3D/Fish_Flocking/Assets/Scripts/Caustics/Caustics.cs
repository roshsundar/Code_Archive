using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caustics : MonoBehaviour
{
    private Projector projecter;
    public MovieTexture mt;

	void Start ()
    {
        projecter = GetComponent<Projector>();
        projecter.material.SetTexture("_ShadowTex", mt);
        mt.loop = true;
        mt.Play();
	}
}
