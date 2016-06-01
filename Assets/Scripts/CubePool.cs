// Copyright 2016 Ashley Bennett. All rights reserved.

using UnityEngine;
using System.Collections.Generic;

// An object pooling class to save time and memory churning when creating and destroying reusable instances of objects.
// Add this script as a component to a game object in the scene, ideally tagging it to make it quick to find.
// Set the prefab and poolSize in the editor.
public class CubePool : ObjectPool
{
    // Overrides base class, (uses new keyword)
    // Upon creation, setup the base class for the pool then activate some cubes
    new public void Awake()
    {
        base.Awake();

        for (int i = 0; i < poolSize_; ++i)
        {
            // This gets an object, then sets the position, (different to the ParticlePool example)
            GameObject obj = Create();
            obj.transform.position = new Vector3(2 * i, 0.5f, 0.0f);
        }
    }

}
