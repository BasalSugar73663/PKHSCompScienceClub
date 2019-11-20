using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroyGrass : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Grass Block")
        {
            Destroy(col.gameObject);
        }
    }
    

}