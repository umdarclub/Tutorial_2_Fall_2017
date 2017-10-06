using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    private RaycastHit hit;
    private Vector3 fwd;
    private Vector3 currPos ;

    void awake()
    {
           
    }

    void Update()
    {
		float distance_of_ray = 10f;
        float turn = 3.0f;
        float speed = 150.0f;
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * turn;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        // use for debugging
        fwd = transform.TransformDirection(Vector3.forward);
        currPos = transform.position;
       
        Debug.DrawRay(currPos, fwd * distance_of_ray, Color.black);

        if (Physics.Raycast(currPos, fwd, out hit, distance_of_ray))
        {
			float distance = hit.distance;
			print(distance + "  " + hit.collider.gameObject.name);
        }
    }

    /*void fixedUpdated()
    {
        fwd = transform.TransformDirection(Vector3.forward);
        currPos = transform.position;
        Debug.DrawRay(currPos, fwd * distance_of_ray, Color.black);

        if (Physics.Raycast(currPos, fwd, out hit, distance_of_ray))
        {
            if (hit.collider.tag == "evil_cynlinder")
            {                    }
             

        }
    }*/
}
