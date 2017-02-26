using CCC.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDown : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Scenes.Load("Ending");
        }
	}
}
