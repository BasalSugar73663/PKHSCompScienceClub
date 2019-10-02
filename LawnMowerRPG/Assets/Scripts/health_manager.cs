using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health_manager : MonoBehaviour {

    public int hp = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public int getHp()
    {
        return hp;
    }

    public void dropHp(int dmg)
    {
        hp -= dmg;
    }
}
