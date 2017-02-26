using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour {

    public Transform inFollow;
    public float speed = 1;


    public void Update()
    {
        if(inFollow != null)
        {
            Vector3 target = new Vector3(inFollow.position.x, transform.position.y, inFollow.position.z);
            Vector3 dir = target - transform.position;
            if (dir.magnitude > 1)
                dir.Normalize();

            transform.position += dir * speed * Time.deltaTime;
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
