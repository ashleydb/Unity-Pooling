// Copyright 2016 Ashley Bennett. All rights reserved.

using UnityEngine;
using System.Collections.Generic;

// An object pooling class to save time and memory churning when creating and destroying reusable instances of objects.
// Add this script as a component to a game object in the scene, ideally tagging it to make it quick to find.
// Set the prefab and poolSize in the editor.
public class ParticlePool : ObjectPool
{
    // Overrides base class.
    // Upon creation, setup the base class for the pool then activate some particles
    new public void Awake()
    {
        base.Awake();

        for (int i = 0; i < poolSize_; ++i)
        {
            // This creates a transform position, then creates an object at that position, (opposite to the CubePool example)
            Transform t = new GameObject().transform;
            t.position = new Vector3(-4 * i, 0.0f, 0.0f);
            Create(t);
        }
    }

    // Overrides base class.
    // Get an object from the pool, just activate it at whatever position it was before
    new public GameObject Create()
    {
        GameObject obj = base.Create();
        if (obj != null)
        {
            obj.SetActive(true);
        }
        return obj;
    }

    // Get an object from the pool, then position it in the world and activate
    public GameObject Create(Transform at)
    {
        GameObject obj = base.Create();
        if (obj != null)
        {
            obj.transform.position = at.position;
            obj.SetActive(true);
        }
        return obj;
    }

}
