using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Justine : Brain {

    public override void ToDo()
    {
        //8H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(0, WayPoint.getWaypoint("JustineDesk").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(28, WayPoint.getWaypoint("StevenDesk").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(28, StevenHello));

        //9H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(60, WayPoint.getWaypoint("JustineDesk").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(62,MariBlaBla1));
        //10H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(150, WayPoint.getWaypoint("BossDesk").position, personnage));
        //11H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(195, WayPoint.getWaypoint("JustineDesk").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(230, WayPoint.getWaypoint("SalleDesEmployes").position, personnage));
        //12H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(270, WayPoint.getWaypoint("WCRed").position, personnage));
        //13H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(300, WayPoint.getWaypoint("PlacardConsierge").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(310,GaetanConv));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(330, WayPoint.getWaypoint("WCRed").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(340, WayPoint.getWaypoint("JustineDesk").position, personnage));
        //14H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(360, WayPoint.getWaypoint("SamanthaDesk").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(365,SamanthaConv));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(390, WayPoint.getWaypoint("JustineDesk").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(395,MariBlabla2));
        //15H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(435, WayPoint.getWaypoint("BossDesk").position, personnage));

        //16H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(480, WayPoint.getWaypoint("JustineDesk").position, personnage));

        //17H

        //18H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(615, WayPoint.getWaypoint("SalleReunionSud").position, personnage));

    }

    //8h30 à 8h45 : Steven reçoit un appel et sort de son bureau. Justine fouille dans son bureau pendant ce temps-là. Elle prend une feuille, la modifie et la remet en place.
    public void StevenHello()
    {

    }
    //9h02 à 10h30 : Justine retourne ensuite dans son bureau et appelle son mari en lui disant qu’elle aura une belle surprise à lui offrir ce soir
    public void MariBlaBla1()
    {

    }
    //13h10 à 13h30 : Discussion avec le Gaétan. 
    public void GaetanConv()
    {

    }
    //14h05 à 14h30 : Discussion avec Samantha. 
    public void SamanthaConv()
    {

    }
    //14h35 à 15h00 : Reçoit un appel téléphonique de son chum lui demandant à quelle heure elle rentre ce soir.
    public void MariBlabla2()
    {

    }
}
