using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grass_behaviour : MonoBehaviour {

    public Material notCut;
    public Material cut;

    private MeshRenderer meshRenderer;

    public GameObject player;
    private Vector3 pos;
    private Vector3 playerPos;
    public bool isCut = false;

    // Use this for initialization
    void Start () {

        pos = transform.position; // Take the current x position

        meshRenderer = GetComponent<MeshRenderer>(); // We are accessing the SpriteRenderer that is attached to the Gameobject
        if (meshRenderer.material == null) // If the material on meshRenderer is null then
            meshRenderer.material = notCut; // Set the sprite to material1
    }
	
	//Update is called once per frame
	void Update () {

        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.up, out hit, 1, 1) == true)
        {
            isCut = true;
            ChangeTheMaterial(1);
        }

        if (isCut == true)
        {
            ChangeTheMaterial(1);
        }

        if (isCut == false)
        {
            ChangeTheMaterial(0);
        }
	}

    void ChangeTheMaterial(int cutStage)
    {
        if (cutStage == 0)
        {
            meshRenderer.material = notCut;
        }
        if (cutStage == 1)
        {
            meshRenderer.material = cut;
        }
        
    }

    bool getCutState()
    {
        return isCut;
    }
}
