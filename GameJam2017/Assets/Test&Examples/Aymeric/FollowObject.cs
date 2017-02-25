using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
        

	}
	

    public void follow(Transform tr)
    {
        gameObject.transform.SetParent(tr);
        gameObject.transform.position = tr.position + new Vector3(0, 10, 0);
    }

    public void stopFollow()
    {
        transform.SetParent(GameObject.Find("Cameras").transform);
    }
}
