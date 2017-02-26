using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsieurX : Brain {

    public override void ToDo()
    {
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(-1, WayPoint.getWaypoint("OutOfTheMap").position, personnage)); // Start

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(570,enableAccusation));

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(600, WayPoint.getWaypoint("InFaceOfSamanthaDesk").position, personnage)); // 18h00 a 18h05

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(605, DrinkCoffee)); // 18h05 a 18h15

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(615, WayPoint.getWaypoint("SalleReunionX").position, personnage)); // 18h15 a 18h30
    }

    public void DrinkCoffee()
    {

    }

    public void enableAccusation()
    {
        DisplayObject.instance.EnableAccusation();
    }
}
