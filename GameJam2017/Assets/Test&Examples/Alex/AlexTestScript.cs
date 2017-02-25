using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlexTestScript : MonoBehaviour {

    public Character roger;

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.C))
        {
            BulleManager.instance.Say("hello", roger);
        }
    }

    void PrintTest()
    {
        print("test1");
    }

    void PrintTest2()
    {
        print("test2");
    }
}
