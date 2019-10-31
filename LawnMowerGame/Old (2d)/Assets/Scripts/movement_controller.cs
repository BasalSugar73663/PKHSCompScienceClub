using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_controller : MonoBehaviour {

    Vector3 pos;
    public float speed = 2.0f;
    public int move_speed = 30;
    private int move_timer = -1;

    // Use this for initialization
    void Start () {
        pos = transform.position; // Take the current position
    }
	
	// Update is called once per frame
	void Update () {

        
        // Inputs
        if (Input.GetKey(KeyCode.A) && transform.position == pos && Physics2D.Raycast(transform.position, Vector2.left, 16) == false && move_timer == -1)
        {           //(-1,0)
            pos += Vector3.left * 16;// Add -1 to pos.x
            move_timer = 0;
        }
        if (Input.GetKey(KeyCode.D) && transform.position == pos && Physics2D.Raycast(transform.position, Vector2.right, 16) == false && move_timer == -1)
        {           //(1,0)
            pos += Vector3.right * 16;// Add 1 to pos.x
            move_timer = 0;
        }
        if (Input.GetKey(KeyCode.W) && transform.position == pos && Physics2D.Raycast(transform.position, Vector2.up, 16) == false && move_timer == -1)
        {           //(0,1)
            pos += Vector3.up * 16; // Add 1 to pos.y
            move_timer = 0;
        }
        if (Input.GetKey(KeyCode.S) && transform.position == pos && Physics2D.Raycast(transform.position, Vector2.down, 16) == false && move_timer == -1)
        {           //(0,-1)
            pos += Vector3.down * 16;// Add -1 to pos.y
            move_timer = 0;
        }

        if (move_timer != -1)
        {
            move_timer += 1;
        }
        if (move_timer >= move_speed)
        {
            move_timer = -1;
        }

        //The Current Position = Move To (the current position to the new position by the speed * Time.DeltaTime)
        transform.position = Vector3.MoveTowards(transform.position, pos, speed);    // Move there

    }
}
