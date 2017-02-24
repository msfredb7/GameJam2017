using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FredTestScript : MonoBehaviour {
    public MyAIPath character;
    public Transform waypointA;
    public Transform waypointB;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            character.SetTarget(waypointA.position);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            character.SetTarget(waypointB.position);
        }
    }
}
