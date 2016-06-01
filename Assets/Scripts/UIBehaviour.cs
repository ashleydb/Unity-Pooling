// Copyright 2016 Ashley Bennett. All rights reserved.

using UnityEngine;
using System.Collections;

// Simple behaviour script for our UI controls
public class UIBehaviour : MonoBehaviour {

    // Just spawn a cube from the Cube Pool
	public void MakeCube ()
    {
        // Make sure the Cube Pool object is tagged appropriately in the editor, (FindWithTag is quicker than Find using strings)
        CubePool pool = GameObject.FindWithTag("CubePool").GetComponent<CubePool>();
        GameObject obj = pool.Create();
	}

}
