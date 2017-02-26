using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeatanBrain : Brain {


    public override void ToDo()
    {
        //8H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(0, WayPoint.getWaypoint("WCBlue").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(40, stephenConv));
        //9H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(60, WayPoint.getWaypoint("WCRed").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(110, WayPoint.getWaypoint("PlacardConsierge").position, personnage));

        //10H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(140, WayPoint.getWaypoint("BossDesk").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(150, WayPoint.getWaypoint("StephenDesk").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(165, StephenOrdinateurUse));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(175, AnnushkaOrdiUse));

        //11H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(185, WayPoint.getWaypoint("WCBlue").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(195, GaetanSoloConv));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(210, WayPoint.getWaypoint("SalleReunionSud").position, personnage));

        //12H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(275, WayPoint.getWaypoint("SalleDesEmployes").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(290, WayPoint.getWaypoint("PlacardConsierge").position, personnage));

        //13h
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(300, GaetanPogneCul));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(330, WayPoint.getWaypoint("WCRed").position, personnage));

        //14H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(360, WayPoint.getWaypoint("PlacardConsierge").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(405, WayPoint.getWaypoint("SalleEntrainement").position, personnage));

        //15H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(465, WayPoint.getWaypoint("InformaticienDesk").position, personnage));


        //16H
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(480, tocGary));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(510, WayPoint.getWaypoint("SalleDesEmployes").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(530, WayPoint.getWaypoint("SalleReunionSud").position, personnage));


        //17H

        //18H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(600, WayPoint.getWaypoint("PlacardConsierge").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(610, EmbrasseEnrique));

        //ScenarioEventManager.AddEvent(new ActionScenarioEvent(125, TocPorteGary));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(620, WayPoint.getWaypoint("SalleReunionSud").position, personnage));
    }

    //8h40 discution stephen?
    public void stephenConv()
    {

    }

    //9h10 discution Annuska ? TODO

    //10h45 Utilise le bureau de stephen
    public void StephenOrdinateurUse()
    {

    }

    //10h52 Stephen le surprend et lui dis d’utiliser l’ordinateur de la stagiaire ? TODO
    public void StephenSuprise()
    {

    }

    //10h55 à 11h05 : Utilise l’ordinateur de Annushka
    public void AnnushkaOrdiUse()
    {

    }

    //11h15 à 11h30 : Se parle seul dans la toilette des hommes
    public void GaetanSoloConv()
    {

    }

    //13h00 à 13h10 : Se pogne le cul dans son placard
    public void GaetanPogneCul()
    {

    }

    //16h00 à 16h10 : Cogne sans réponse +Gaétan dit à Gary qu’il faudrait bien qu’il le laisse nettoyer son bureau un jour
    public void tocGary()
    {

    }

    //18h10 à 18h20 : Embrasse Enrique
    public void EmbrasseEnrique()
    {

    }
}
