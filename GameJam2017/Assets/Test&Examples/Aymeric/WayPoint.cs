using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour {

    static WayPoint _instance;

    static WayPoint instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = GameObject.Find("WayPoint").GetComponent<WayPoint>();
            }
            return _instance;
        }
    }
	
    public static Transform getWaypoint(string name)
    {
        return instance.transform.Find(name);
    }

}
