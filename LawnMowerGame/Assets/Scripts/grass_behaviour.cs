﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grass_behaviour : MonoBehaviour {

    public Sprite notCut;
    public Sprite cut;

    private SpriteRenderer spriteRenderer;

    GameObject player;
    Vector3 pos;
    Vector3 playerPos;
    public bool isCut = false;

    // Use this for initialization
    void Start () {

        pos = transform.position; // Take the current position

        player = GameObject.Find("Player");

        spriteRenderer = GetComponent<SpriteRenderer>(); // We are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer.sprite == null) // If the sprite on spriteRenderer is null then
            spriteRenderer.sprite = notCut; // Set the sprite to sprite1
    }
	
	//Update is called once per frame
	void Update () {

        playerPos = player.transform.position;

        if (pos == playerPos)
        {
            isCut = true;
        }

        if (isCut == true)
        {
            ChangeTheSprite(1);
        }
	}

    void ChangeTheSprite(int cutStage)
    {
        if (cutStage == 0)
        {
            spriteRenderer.sprite = notCut;
        }
        if (cutStage == 1)
        {
            spriteRenderer.sprite = cut;
        }
        
    }

    bool getCutState()
    {
        return isCut;
    }
}