using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnriqueBrain : Brain
{

    public override void ToDo()
    {
        //8H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(1, WayPoint.getWaypoint("BossDesk").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(30, WayPoint.getWaypoint("SalleEntrainement").position, personnage));
        //9H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(75, WayPoint.getWaypoint("BossDesk").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(121, WayPoint.getWaypoint("InformaticienDesk").position, personnage));
        //10H
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(125, TocPorteGary));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(130, WayPoint.getWaypoint("SalleEntrainement").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(158, WayPoint.getWaypoint("BossDesk").position, personnage));
        //11H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(195, WayPoint.getWaypoint("WCBlue").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(210, WCHommeStevenConv));
        //12H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(225, WayPoint.getWaypoint("PlacardConsierge").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(240, NoteConsierge));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(245, WayPoint.getWaypoint("BossDesk").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(250, NoteConsierge));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(280, WayPoint.getWaypoint("SalleEntrainement").position, personnage));
        //13H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(320, WayPoint.getWaypoint("BossDesk").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(350, WayPoint.getWaypoint("SalleEntrainement").position, personnage));
        //14H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(395, WayPoint.getWaypoint("BossDesk").position, personnage));
        //15H
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(450, discutionContratSoir));
        //16H
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(510, appelGary));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(530, appelSamantha));
        //18H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(620, WayPoint.getWaypoint("SalleReunionNord").position, personnage));
    }

    public void TocPorteGary()
    {

    }

    //Check si pas de redondance avec le script de Steven
    public void WCHommeStevenConv()
    {

    }

    public void NoteConsierge()
    {

    }

    public void GaryAppel()
    {

    }

    //Check si pas de redondance avec le script de Annushka
    public void ConvAnnushka()
    {

    }

    public void discutionContratSoir()
    {

    }

    //16h30
    public void appelGary()
    {

    }

    public void appelSamantha()
    {

    }

    


}

