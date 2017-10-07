using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autodestroy : MonoBehaviour {
    /*Attach this class to a ParticleSystem game object in order to destroy it automatically upon completion of its lifetime.
    This script includes an optional delay on deletion that can be set in the engine dev environment. Here that is used to ensure
    that the explosion sound effect is not set short.*/
    public float delay;
	void Start () {
        ParticleSystem parts = gameObject.GetComponent<ParticleSystem>();
        Destroy(gameObject, parts.duration + parts.startLifetime + delay);
	}

}
