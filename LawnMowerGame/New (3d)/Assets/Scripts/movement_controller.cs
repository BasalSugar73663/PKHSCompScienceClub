﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_controller : MonoBehaviour {

    Vector3 pos;
    public float speed = 2.0f;
    public int move_speed = 30;
    //private int move_timer = -1;

    // Use this for initialization
    void Start () {
        pos = transform.position; // Take the current position
    }
	
	// Update is called once per frame
	void Update () {

        RaycastHit hit;
        
        // Inputs
        if (Input.GetKey(KeyCode.A) && transform.position == pos && Physics.Raycast(transform.position, Vector3.left, out hit, 1, 1) == false/* && move_timer == -1*/)
        {           //(-1,0)
            transform.rotation = Quaternion.Euler(0, 0, 0);
            pos += Vector3.left * 1;// Add -1 to pos.x
            //move_timer = 0;
        }
        if (Input.GetKey(KeyCode.D) && transform.position == pos && Physics.Raycast(transform.position, Vector3.right, out hit, 1, 1) == false /*&& move_timer == -1*/)
        {           //(1,0)
            transform.rotation = Quaternion.Euler(0, 180, 0);
            pos += Vector3.right * 1;// Add 1 to pos.x
            //move_timer = 0;
        }
        if (Input.GetKey(KeyCode.W) && transform.position == pos && Physics.Raycast(transform.position, Vector3.forward, out hit, 1, 1) == false/* && move_timer == -1*/)
        {           //(0,1)
            transform.rotation = Quaternion.Euler(0, 90, 0);
            pos += Vector3.forward * 1; // Add 1 to pos.y
            //move_timer = 0;
        }
        if (Input.GetKey(KeyCode.S) && transform.position == pos && Physics.Raycast(transform.position, Vector3.back, out hit, 1, 1) == false/* && move_timer == -1*/)
        {           //(0,-1)
            transform.rotation = Quaternion.Euler(0, 270, 0);
            pos += Vector3.back * 1;// Add -1 to pos.y
            //move_timer = 0;
        }

        /*
        if (move_timer != -1)
        {
            move_timer += 1;
        }
        if (move_timer >= move_speed)
        {
            move_timer = -1;
        }*/

        //The Current Position = Move To (the current position to the new position by the speed * Time.DeltaTime)
        transform.position = Vector3.MoveTowards(transform.position, pos, speed);    // Move there

    }
}
