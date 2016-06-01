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
            // This creates a transform position, then creates an object at that position, (different to the CubePool example)
            Vector3 position = new Vector3(-4 * i, 0.0f, 0.0f);
            Create(position);
        }
    }

}
