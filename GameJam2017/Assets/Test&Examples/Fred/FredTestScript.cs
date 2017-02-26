using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FredTestScript : MonoBehaviour {
    public PasswordWall passwordWallPrefab;
    public Canvas parent;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            PasswordWallSpawner.LaunchPasswordWall(Prout, "hello");
        }
    }

    void Prout()
    {
        print("prout");
    }
}
