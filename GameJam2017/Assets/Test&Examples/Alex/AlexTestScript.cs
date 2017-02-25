using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlexTestScript : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ActionScenarioEvent newAction1 = new ActionScenarioEvent(10, PrintTest2);
            ScenarioEventManager.AddEvent(newAction1);
            ActionScenarioEvent newAction = new ActionScenarioEvent(5, PrintTest);
            ScenarioEventManager.AddEvent(newAction);
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
