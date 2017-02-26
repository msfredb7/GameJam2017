using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FredTestScript : MonoBehaviour {
    public Sprite spr;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            SpriteSpawner.instance.SpawnSprite(spr, WayPoint.getWaypoint("BossDesk").position);
        }
    }
}
