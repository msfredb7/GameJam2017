using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bob : Brain {

    public enum BobAction {  }

    public override void ToDo()
    {
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(5,WayPoint.getWaypoint("WCRed").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(10, WayPoint.getWaypoint("WCBlue").position, personnage));
    }
}
