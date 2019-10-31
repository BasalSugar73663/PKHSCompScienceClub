using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health_manager : MonoBehaviour {

    public int hp;
    public bool dead;

	// Use this for initialization
	void Start () {
        hp = 5;
	}

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            dead = true;
        }
    }

    public int getHp()
    {
        return hp;
    }

    public void dropHp(int dmg)
    {
        this.hp -= dmg;
    }
    
}
