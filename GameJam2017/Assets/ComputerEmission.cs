using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerEmission : MonoBehaviour {

    public float delay;
    
	public void Init () {
        Destroy(this.gameObject,delay);
	}
}
