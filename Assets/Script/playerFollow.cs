using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 public class playerFollow : MonoBehaviour  {      public Transform player;     public Transform cam;     private Vector3 currentPosition;        // Update is called once per frame     void Update ()      {
        float cameraHeight = 3f;         if (player)         {             currentPosition = new Vector3(player.position.x, cameraHeight, player.position.z - 3);             cam.SetPositionAndRotation(currentPosition, Quaternion.Euler(30.0f, 0.0f, 0.0f));         }     } }