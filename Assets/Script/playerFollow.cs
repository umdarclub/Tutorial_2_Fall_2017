using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFollow : MonoBehaviour 
{

    private Transform player, cam;
    private Vector3 currentPosition;
    private float cameraHeight = 3f;

    //use awake to init variables, that are private
    //Essentially Awake can be seen a constructor
    //for any class that inherets from MonoBehaviour
    private void Awake()
    {
        player = GameObject.Find("Robot").transform;
        cam = GameObject.Find("Main Camera").transform;
    }


    // Update is called once per frame
    void Update () 
    {
        if (player)
        {
            currentPosition = new Vector3(player.position.x, cameraHeight, player.position.z - 3);
            cam.SetPositionAndRotation(currentPosition, Quaternion.Euler(20.0f, 0.0f, 0.0f));
        }
    }
}