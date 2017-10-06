using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    private RaycastHit hit;
    private Vector3 fwd, currPos;
    private float distance_of_ray, turn, speed;
    public Transform explosion;

    void Awake()
    {
        distance_of_ray = 10f;
        speed = 150f;
        turn = 3f;
        
    }

    void FixedUpdate()
    {
        raycasting();  
    }

    private void raycasting()
    {
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
            //float distance = hit.distance;
            //print(distance + "  " + hit.collider.gameObject.name);

            if (hit.collider.tag == "evil_cynlinder")
            {
                Destroy(hit.collider.gameObject);
                Transform explosionClone = Instantiate(explosion, hit.collider.transform.position, hit.collider.transform.rotation);
                Destroy(explosionClone.gameObject, 3);
            }
        }
    }

}
