using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnriqueBrain : Brain
{

    public override void ToDo()
    {

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(1, WayPoint.getWaypoint("BossDesk").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(30, WayPoint.getWaypoint("SalleEntrainement").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(75, WayPoint.getWaypoint("BossDesk").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(121, WayPoint.getWaypoint("InformaticienDesk").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(130, WayPoint.getWaypoint("SalleEntrainement").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(158, WayPoint.getWaypoint("BossDesk").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(195, WayPoint.getWaypoint("WCBlue").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(225, WayPoint.getWaypoint("PlacardConsierge").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(245, WayPoint.getWaypoint("BossDesk").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(280, WayPoint.getWaypoint("SalleEntrainement").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(320, WayPoint.getWaypoint("BossDesk").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(350, WayPoint.getWaypoint("SalleEntrainement").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(395, WayPoint.getWaypoint("BossDesk").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(620, WayPoint.getWaypoint("SalleReunionNord").position, personnage));
    }
}

