using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FredTestScript : MonoBehaviour {
    public Character character;
    public Transform waypointA;
    public Transform waypointB;
    public Transform waypointC;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            character.MoveTo(waypointA.position);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            character.MoveTo(waypointB.position);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            character.MoveTo(waypointC.position);
        }
    }
}
