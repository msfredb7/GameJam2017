using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Samantha : Brain {

    public override void ToDo()
    {
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(0, WayPoint.getWaypoint("SamanthaDesk").position, personnage)); // 8h00 a 8h10

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(10, MakeTexto1));                                             // 8h10 a 8h30

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(30, WayPoint.getWaypoint("BossDesk").position, personnage)); // 8h30 a 8h40

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(40, Drague1));                                           // 8h40 a 9h00

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(60, WayPoint.getWaypoint("SamanthaDesk").position, personnage)); // 9h00 a 9h10

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(70, TravailPersonnel)); // 9h10 a 9h30

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(90, WayPoint.getWaypoint("AnnushkaDesk").position, personnage)); // 9h30 a 9h40

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(100, ParleAvecAnn)); // 9h40 a 10h10

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(130, WayPoint.getWaypoint("WCRed").position, personnage)); // 10h10 a 10h15

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(135, Maquillage)); // 10h15 a 11h00

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(180, WayPoint.getWaypoint("BossDesk").position, personnage)); // 11h00 a 11h20

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(200, Drague2)); // 11h20 a 11h50

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(230, WayPoint.getWaypoint("SalleDesEmployes").position, personnage)); // 11h50 a 12h00

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(240, EcouteStephen)); // 12h00 a 12h30

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(270, WayPoint.getWaypoint("SamanthaDesk").position, personnage)); // 12h30 a 12h35

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(275, MakeTexto2)); // 12h35 a 13h00

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(300, WayPoint.getWaypoint("BossDesk").position, personnage)); // 13h00 a 13h10

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(310, MemoBoss)); // 13h10 a 13h20

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(320, WayPoint.getWaypoint("AnnushkaDesk").position, personnage)); // 13h20 a 13h30

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(330, ParleAvecAnn2)); // 13h30 a 13h55

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(355, WayPoint.getWaypoint("SamanthaDesk").position, personnage)); // 13h55 a 14h05

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(365, ParleAvecJustine)); // 14h05 a 14h30

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(390, WayPoint.getWaypoint("BossDesk").position, personnage)); // 14h30 a 14h40

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(400, Drague3)); // 14h40 a 15h30

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(450, WayPoint.getWaypoint("PlacardConsierge").position, personnage)); // 15h30 a 15h40

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(460, PrendEauJavel)); // 15h40 a 16h00

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(480, WayPoint.getWaypoint("SamanthaDesk").position, personnage)); // 16h00 a 16h07

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(487.5f, WayPoint.getWaypoint("StephenDesk").position, personnage)); // 16h07 a 16h15

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(495, InviteStephen)); // 16h15 a 16h45

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(525, WayPoint.getWaypoint("SamanthaDesk").position, personnage)); // 16h45 a 16h50

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(530, SiteWebJavel)); // 16h50 a 17h10

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(550, Appel_M_X)); // 17h10 a 17h30

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(230, WayPoint.getWaypoint("SalleDesEmployes").position, personnage)); // 11h50 a 12h00


    }

    public void MakeTexto1()
    {
        personnage.GetCell().AddTexto("T'en reviendras pas Natasha, Enrique porte sa cravate rouge aujourd'hui. Y sait clairement que c'est ma préférée en plus", "8h10", "Enrique");
        personnage.GetCell().AddTexto("Oops lis pas le dernier message, c'était pas pour toi !", "8h10", "Enrique");
        personnage.GetCell().AddTexto("T'en reviendras pas Natasha, Enrique porte sa cravate rouge aujourd'hui. Y sait clairement que c'est ma préférée en plus", "8h10", "Natasha");
    }

    public void Drague1()
    {
        BulleManager.instance.Say("\nSalut mon beau! \n Grosse journée en vue? \n Belle cravate en passant \n ;)",personnage,10);
    }

    public void TravailPersonnel()
    {

    }

    public void ParleAvecAnn()
    {

    }

    public void Maquillage()
    {

    }

    public void Drague2()
    {

    }

    public void EcouteStephen()
    {

    }

    public void MakeTexto2()
    {

    }

    public void MemoBoss()
    {

    }

    public void ParleAvecAnn2()
    {

    }

    public void ParleAvecJustine()
    {

    }

    public void Drague3()
    {

    }

    public void PrendEauJavel()
    {

    }

    public void InviteStephen()
    {

    }

    public void SiteWebJavel()
    {

    }

    public void Appel_M_X()
    {

    }
}
