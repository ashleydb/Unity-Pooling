// Copyright 2016 Ashley Bennett. All rights reserved.

using UnityEngine;
using System.Collections;

// Simple behaviour script for our Cube prefab
public class CubeBehaviour : MonoBehaviour {

    // Destroying this object means returning it to the Cube Pool
	public void Destroy ()
    {
        // Make sure the Cube Pool object is tagged appropriately in the editor, (FindWithTag is quicker than Find using strings)
        CubePool pool = GameObject.FindWithTag("CubePool").GetComponent<CubePool>();
        pool.Destroy(gameObject);
	}

}
