using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempoTestMouvement : MonoBehaviour {


	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody>().AddForce(new Vector3(1, 0, 0));
	}
}
