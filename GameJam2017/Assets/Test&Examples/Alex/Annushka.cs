using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Annushka : Brain {

    public override void ToDo()
    {
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(0, WayPoint.getWaypoint("AnnushkaDesk").position, personnage)); // 8h a 8h10

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(10, WayPoint.getWaypoint("InformaticienDesk").position, personnage)); // 8h10 a 8h20

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(20, CogneChezGary)); // 8h20 a 8h30

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(30, WayPoint.getWaypoint("AnnushkaDesk").position, personnage)); // 8h30 a 8h45

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(45, WorkingAtDesk)); // 8h45 a 9h00

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(60, WayPoint.getWaypoint("WCRed").position, personnage)); // 9h00 a 9h05

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(65, JasetteAvecGaetan)); // 9h05 a 9h30

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(90, WayPoint.getWaypoint("AnnushkaDesk").position, personnage)); // 9h30 a 9h35

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(95, TempLibre)); // 9h35 a 10h10

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(130, WayPoint.getWaypoint("StevenDesk").position, personnage)); // 10h10 a 10h30

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(150, RencontreAvecSteven)); // 10h30 a 11h00

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(180, WayPoint.getWaypoint("WCRed").position, personnage)); // 11h00 a 11h10

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(190, FaitPopo)); // 11h10 a 11h25

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(205, WayPoint.getWaypoint("AnnushkaDesk").position, personnage)); // 11h25 a 11h30

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(210, DiscussionAvecStephen)); //11h30 a 11h50

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(230, WayPoint.getWaypoint("SalleDesEmployes").position, personnage)); // 11h50 a 12h00

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(240, EcouteStephen)); // 12h00 a 12h30

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(270, WayPoint.getWaypoint("WCRed").position, personnage)); // 12h30 a 12h40

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(280, DiscussionTelephonique)); // 12h40 a 13h00

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(300, WayPoint.getWaypoint("AnnushkaDesk").position, personnage)); // 13h00 a 13h20

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(320, TempLibre)); // 13h20 a 13h30

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(330, DiscussionAvecSamantha)); // 13h30 a 13h55

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(355, WayPoint.getWaypoint("SalleEntrainement").position, personnage)); // 13h55 a 14h05

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(365, EntrainementAvecEnrique)); // 14h05 a 14h50

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(410, WayPoint.getWaypoint("AnnushkaDesk").position, personnage)); // 14h50 a 15h00

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(420, ProblemeAvecOrdinateur)); // 15h00 a 15h15

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(435, WayPoint.getWaypoint("InformaticienDesk").position, personnage)); // 15h15 a 15h30

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(450, CogneChezGary)); // 15h30 a 15h45

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(465, WayPoint.getWaypoint("AnnushkaDesk").position, personnage)); // 15h45 a 16h00

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(480, WorkingAtDesk)); // 16h00 a 17h00

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(540, WayPoint.getWaypoint("WCRed").position, personnage)); // 17h00 a 17h05

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(545, AppelAuToilette)); // 17h05 a 17h30

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(570, WayPoint.getWaypoint("PlacardConsierge").position, personnage)); // 17h30 a 17h45

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(585, DemandePourGaetan)); // 17h45 a 18h00

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(600, WayPoint.getWaypoint("SalleEntrainement").position, personnage)); // 18h00 a 18h05

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(605, OuvertureDuColis)); // 18h05 a 18h15

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(630, WayPoint.getWaypoint("SalleReunionSud").position, personnage)); // 18h15 a 18h30
    }

    public void CogneChezGary()
    {
        personnage.Stop();
        personnage.Teleport(WayPoint.getWaypoint("InformaticienDesk").position);
        // Bruit de cognage?
    }

    public void WorkingAtDesk()
    {
        personnage.Stop();
        // Bruit, animation work ?
    }

    public void JasetteAvecGaetan()
    {
        // TODO : DIALOGUE
    }

    public void TempLibre()
    {
        personnage.Stop();
    }

    public void RencontreAvecSteven()
    {
        personnage.Stop();
    }

    public void FaitPopo()
    {
        personnage.Stop();
        // popo ?
    }

    public void DiscussionAvecStephen()
    {
        // TODO : DIALOGUE
    }

    public void EcouteStephen()
    {
        // dialogue gerer par stephen?
    }

    public void DiscussionTelephonique()
    {
        // TODO : Dialogue
    }

    public void DiscussionAvecSamantha()
    {
        // TODO : Dialogue
    }

    public void EntrainementAvecEnrique()
    {
        // TODO : Dialogue
    }

    public void ProblemeAvecOrdinateur()
    {
        // TODO : Dialogue
    }

    public void AppelAuToilette()
    {
        // TODO : Dialogue
    }

    public void DemandePourGaetan()
    {

    }

    public void OuvertureDuColis()
    {

    }
}
