using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class health_bar : MonoBehaviour {

    public Image[] hearts;
    public Sprite heart1;
    public Sprite heart2;

    private SpriteRenderer spriteRenderer;
    GameObject player;

    public int hp;
    public int nbrHearts;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {

        hp = player.GetComponent<health_manager>().getHp();

        for (int i = 0; i < hearts.Length; i++)
        {

            if (i < hp)
            {
                hearts[i].sprite = heart1;
            }
            else
            {
                hearts[i].sprite = heart2;
            }

            if (i < nbrHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }

        if (hp <= 0)
        {
            SceneManager.LoadScene("MainMenu");
        }

	}
}
