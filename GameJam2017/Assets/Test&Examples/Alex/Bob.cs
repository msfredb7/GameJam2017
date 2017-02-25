using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bob : Brain {

    public override void ToDo()
    {
       /* ScenarioEventManager.AddEvent(new MoveScenarioEvent(3,WayPoint.getWaypoint("WCRed").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(20, WayPoint.getWaypoint("WCBlue").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(40, WayPoint.getWaypoint("Entree").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(60, WayPoint.getWaypoint("StephenDesk").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(80, WayPoint.getWaypoint("JustineDesk").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(100, WayPoint.getWaypoint("StevenDesk").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(120, WayPoint.getWaypoint("AraskaDesk").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(140, WayPoint.getWaypoint("SamanthaDesk").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(160, WayPoint.getWaypoint("SalleDesEmployes").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(180, WayPoint.getWaypoint("SalleEntrainement").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(200, WayPoint.getWaypoint("PlacardConsierge").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(220, WayPoint.getWaypoint("SalleReunionSud").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(240, WayPoint.getWaypoint("SalleReunionNord").position, personnage));*/
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(5, WayPoint.getWaypoint("BossDesk").position, personnage));
       // ScenarioEventManager.AddEvent(new MoveScenarioEvent(5, WayPoint.getWaypoint("InformaticienDesk").position, personnage));



    }
}
