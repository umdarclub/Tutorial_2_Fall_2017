using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autodestroy : MonoBehaviour {
/*Attach this class to a ParticleSystem game object in order to destroy it automatically upon completion of its lifetime.*/

	void Start () {
        ParticleSystem parts = gameObject.GetComponent<ParticleSystem>();
        Destroy(gameObject, parts.duration + parts.startLifetime);
	}

}
