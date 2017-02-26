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

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(60, WayPoint.getWaypoint("WCRed").position, personnage)); // 9h00 a 9h05

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(65, JasetteAvecGaetan)); // 9h05 a 9h30

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(90, WayPoint.getWaypoint("AnnushkaDesk").position, personnage)); // 9h30 a 9h35

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(130, WayPoint.getWaypoint("StevenDesk").position, personnage)); // 10h10 a 10h30

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(150, RencontreAvecSteven)); // 10h30 a 11h00

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(180, WayPoint.getWaypoint("WCRed").position, personnage)); // 11h00 a 11h10

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(205, WayPoint.getWaypoint("AnnushkaDesk").position, personnage)); // 11h25 a 11h30

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(210, DiscussionAvecStephen)); //11h30 a 11h50

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(230, WayPoint.getWaypoint("SalleDesEmployes").position, personnage)); // 11h50 a 12h00

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(270, WayPoint.getWaypoint("WCRed").position, personnage)); // 12h30 a 12h40

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(300, WayPoint.getWaypoint("AnnushkaDesk").position, personnage)); // 13h00 a 13h20

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(355, WayPoint.getWaypoint("SalleEntrainement").position, personnage)); // 13h55 a 14h05

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(410, WayPoint.getWaypoint("AnnushkaDesk").position, personnage)); // 14h50 a 15h00

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(435, WayPoint.getWaypoint("InformaticienDesk").position, personnage)); // 15h15 a 15h30

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(450, CogneChezGary)); // 15h30 a 15h45

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(465, WayPoint.getWaypoint("AnnushkaDesk").position, personnage)); // 15h45 a 16h00

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
        BulleManager.instance.Say("Ça va bien \nlà-dedans?", ScenarioManager.instance.Gaetan, 5);
        BulleManager.instance.Say("Qui parle à moi?", personnage, 5,5);
        BulleManager.instance.Say("C’est moi Gaétan \nle concierge, c’est \nla première fois que \nnous avons la chance de parler", ScenarioManager.instance.Gaetan, 10 , 10);
        BulleManager.instance.Say(": Pas sur que être \nune chance…", personnage, 5,20);
        BulleManager.instance.Say("Allez je vous laisse \ntranquille,\n bonne journée", ScenarioManager.instance.Gaetan, 5,25);

    }



    public void RencontreAvecSteven()
    {
        BulleManager.instance.Say("Avais-tu des\n questions sur \nla compagnie?", ScenarioManager.instance.Steven, 5);
        BulleManager.instance.Say("Oui, pourquoi Samantha\n travailler ici?", ScenarioManager.instance.Annushka, 5, 5);
        BulleManager.instance.Say("Bonne question, \nc’est Enrique qui\n a insisté pour l’engager", ScenarioManager.instance.Steven, 10, 10);
        BulleManager.instance.Say("Pas très surprenant… \nPas plus macho que lui", ScenarioManager.instance.Annushka, 5, 20);
        BulleManager.instance.Say("Je ne te le\n fais pas dire !", ScenarioManager.instance.Steven, 5, 25);
    }

    public void DiscussionAvecStephen()
    {

    }

    public void EntrainementAvecEnrique()
    {
        // TODO : Dialogue
    }

    public void ProblemeAvecOrdinateur()
    {
        BulleManager.instance.Say("Saletée de machine !!!!!", personnage, 5);
    }

    public void AppelAuToilette()
    {
        BulleManager.instance.Say("***Comment se passe\n la mission?***", ScenarioManager.instance.Annushka, 5);
        BulleManager.instance.Say("Pas mission, stage", ScenarioManager.instance.Annushka, 5, 5);
        BulleManager.instance.Say("***Et comment est\n ton patron?***", ScenarioManager.instance.Annushka, 5, 10);
        BulleManager.instance.Say("Stupide, incompétent,\n macho, mérite la mort.", ScenarioManager.instance.Annushka, 10, 15);
        BulleManager.instance.Say("***Promet moi \nque tu ne feras\n rien de stupide***", ScenarioManager.instance.Annushka, 5, 25);
        BulleManager.instance.Say("Promis père", ScenarioManager.instance.Annushka, 5, 30);
    }

    public void DemandePourGaetan()
    {
        BulleManager.instance.Say("Besoin débarrer\n salle entrainement", ScenarioManager.instance.Annushka, 5);
        BulleManager.instance.Say("Aucun problème,\n suis-moi", ScenarioManager.instance.Gaetan, 5, 5);
        BulleManager.instance.Say("Merci monsieur.", ScenarioManager.instance.Annushka, 5, 10);

    }

    public void OuvertureDuColis()
    {
        BulleManager.instance.Say("Miam bon gâteau\n à la vanille!", ScenarioManager.instance.Annushka, 10);
    }
}
