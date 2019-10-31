using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock_behaviour : MonoBehaviour {

    GameObject player;
    Vector3 pos;
    Vector3 playerPos;
    private bool lastMove = false;

    // Use this for initialization
    void Start () {

        player = GameObject.Find("Player");
        pos = transform.position; // Take the current position

    }
	
	// Update is called once per frame
	void Update () {

        playerPos = player.transform.position;

        if (pos == playerPos && lastMove == false)
        {
            player.GetComponent<health_manager>().dropHp(1);
            lastMove = true;
        }
        if (pos != playerPos)
        {
            lastMove = false;
        }

    }
}
