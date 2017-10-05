using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastingRay : MonoBehaviour {


    public float speed, turn;
    private RaycastHit hit;
    private Vector3 fwd;
    private Vector3 currPos ;

    void awake()
    {
       

    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }

    void fixedUpdated()
    {
        fwd = transform.TransformDirection(Vector3.forward);
        currPos = transform.position; 
        if (Physics.Raycast(currPos, fwd, out hit, 100))
        {
           Debug.Log("Found an object - distance: " + hit.distance);
            Debug.DrawRay(currPos, fwd,Color.yellow);
        }

    }

    
	
}
