# Unity-Pooling
A simple scene built in Unity to demonstrate object pooling.

The basic scene contains a ground plane, a camera, (with a Physics Raycaster for input,) a light, a UI canvas containing a button, (to spawn cubes from the pool,) and an Event System for input.

There are also two examples of Pools, a ParticlePool and CubePool, (each with an appropriate Tag in the editor.) These both have a respective script component which each derive from ObjectPool.

You can see that these two pools are independent, with separate pool sizes and prefabs to spawn, but share common code for managing the objects in the pools.

The two prefabs the pools use are the Cube, (which has an event trigger to be destroied when clicked,) and the PurpleParticles which just look nice.
