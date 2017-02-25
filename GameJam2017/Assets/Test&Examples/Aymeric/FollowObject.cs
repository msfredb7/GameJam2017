using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour {

    Transform inFollow;


    public void Update()
    {
        if(inFollow != null)
        {
            transform.position = inFollow.position + new Vector3(0, 10, 0);
        }
        
    }

    public void follow(Transform tr)
    {
        inFollow = tr;
    }

    public void stopFollow()
    {
        inFollow = null;
    }
}
