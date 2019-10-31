using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public GameObject[] Grass = new GameObject[77];
    public GameObject prefab;

	// Use this for initialization
	void Start ()
    {

		for ( int i = 0; i < 7; i++)
        {
            for ( int j = 0; j < 11; j++)
            {
                Instantiate(Grass[i + j], new Vector3(j, i, 0), Quaternion.identity);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
