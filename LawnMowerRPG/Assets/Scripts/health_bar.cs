using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health_bar : MonoBehaviour {

    public Sprite heart1;
    public Sprite heart2;
    public Sprite heart3;

    private SpriteRenderer spriteRenderer;
    public GameObject player;

    private int hp;

    // Use this for initialization
    void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {

        hp = player.GetComponent<health_manager>().getHp();

        ChangeTheSprite(hp);


	}

    void ChangeTheSprite(int health)
    {
        if (health == 1)
        {
            spriteRenderer.sprite = heart1;
        }
        if (health == 2)
        {
            spriteRenderer.sprite = heart2;
        }
        if (health == 2)
        {
            spriteRenderer.sprite = heart3;
        }

    }
}
