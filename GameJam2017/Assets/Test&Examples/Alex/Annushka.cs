﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Annushka : Brain {

    public override void ToDo()
    {
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(0, WayPoint.getWaypoint("AnnushkaDesk").position, personnage)); // 8h a 8h10

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(10, WayPoint.getWaypoint("InformaticienDesk").position, personnage)); // 8h10 a 8h20

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(25, CogneChezGary)); // 8h20 a 8h30

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(30, WayPoint.getWaypoint("AnnushkaDesk").position, personnage)); // 8h30 a 8h45

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(60, WayPoint.getWaypoint("WCRed").position, personnage)); // 9h00 a 9h05

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(72, JasetteAvecGaetan)); // 9h05 a 9h30

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(90, WayPoint.getWaypoint("AnnushkaDesk").position, personnage)); // 9h30 a 9h35

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(95, WorkingAtDesk1));

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(140, WayPoint.getWaypoint("StevenDesk_Visiteur").position, personnage)); // 10h10 a 10h30

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(141, TurnTop1)); // 9h05 a 9h30

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(150, RencontreAvecSteven)); // 10h30 a 11h00

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(180, WayPoint.getWaypoint("WCRed").position, personnage)); // 11h00 a 11h10

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(205, WayPoint.getWaypoint("AnnushkaDesk").position, personnage)); // 11h25 a 11h30

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(210, WorkingAtDesk4));

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(210, DiscussionAvecStephen)); //11h30 a 11h50

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(230, WayPoint.getWaypoint("SalleDesEmployes_Annushka").position, personnage)); // 11h50 a 12h00

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(232, TurnTop1));

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(270, WayPoint.getWaypoint("WCRed").position, personnage)); // 12h30 a 12h40

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(300, WayPoint.getWaypoint("AnnushkaDesk").position, personnage)); // 13h00 a 13h20

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(320, WorkingAtDesk2));

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(355, WayPoint.getWaypoint("SalleEntrainement_Talk").position, personnage)); // 13h55 a 14h05

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(370, DiscussionAvecEnrique)); // 14h05 

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(410, WayPoint.getWaypoint("AnnushkaDesk").position, personnage)); // 14h50 a 15h00

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(420, WorkingAtDesk3));

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(435, WayPoint.getWaypoint("InformaticienDesk").position, personnage)); // 15h15 a 15h30

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(445, TravailPersonnel));

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(450, CogneChezGary)); // 15h30 a 15h45

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(465, WayPoint.getWaypoint("AnnushkaDesk").position, personnage)); // 15h45 a 16h00

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(480, TravailPersonnel1));

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(540, WayPoint.getWaypoint("WCRed").position, personnage)); // 17h00 a 17h05

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(545, AppelAuToilette)); // 17h05 a 17h30

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(570, WayPoint.getWaypoint("PlacardConsierge_Visiteur").position, personnage)); // 17h30 a 17h45

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(570, TurnTop1));

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(585, DemandePourGaetan)); // 17h45 a 18h00

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(600, WayPoint.getWaypoint("SalleEntrainement").position, personnage)); // 18h00 a 18h05

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(605, OuvertureDuColis)); // 18h05 a 18h15

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(630, WayPoint.getWaypoint("SalleReunionAnn").position, personnage)); // 18h15 a 18h30
    }


    public void TravailPersonnel1()
    {
        ClavierAnimation(60);
    }

    public void TravailPersonnel()
    {
        ClavierAnimation(15);
    }

    public void TurnTop1()
    {
        personnage.defaultDirection = Character.Direction.Up;
        personnage.SetDirectionIn(Character.Direction.Down, 40);
    }


    public void DiscussionAvecEnrique()
    {
        Personne enrique = ScenarioManager.instance.Enrique;
        personnage.focus = enrique;
        enrique.focus = personnage;

        personnage.defaultDirection = Character.Direction.Up;
        personnage.SetDirectionIn(Character.Direction.Down, 13);


        BulleManager.instance.Say("Check mes pipes !", enrique, 3, 0);
        BulleManager.instance.Say("Pas très impressionnée...", personnage, 3,3);
        BulleManager.instance.Say("Pourtant j'passe \nmes journées à \nm'entrainer", enrique, 3,6);
        BulleManager.instance.Say("Devrais plutôt travailler", personnage, 3, 9);

        enrique.SetFocusIn(null, 12);
        personnage.SetFocusIn(null, 12);
    }


    public void CogneChezGary()
    {
        personnage.defaultDirection = Character.Direction.Up;
        personnage.SetDirectionIn(Character.Direction.Down, 6);
        personnage.Stop();
        personnage.Teleport(WayPoint.getWaypoint("InformaticienDesk").position);
        // Bruit de cognage?
        
    }

    public void WorkingAtDesk()
    {
        ClavierAnimation(10);
    }

    public void WorkingAtDesk1()
    {
        ClavierAnimation(35);
    }

    public void WorkingAtDesk2()
    {
        ClavierAnimation(35);
    }

    public void WorkingAtDesk3()
    {
        ClavierAnimation(15);
    }

    public void WorkingAtDesk4()
    {
        ClavierAnimation(20);
    }

    public void JasetteAvecGaetan()
    {
        Personne gaet = ScenarioManager.instance.Gaetan;
        personnage.focus = gaet;
        gaet.focus = personnage;

        BulleManager.instance.Say("Ça va bien \nlà-dedans?", ScenarioManager.instance.Gaetan, 5, 0);
        BulleManager.instance.Say("Qui parle à moi?", personnage, 3,5);
        BulleManager.instance.Say("C’est moi Gaétan \nle concierge, c’est \nla première fois que \nnous avons la chance de parler", ScenarioManager.instance.Gaetan, 5 , 8);
        BulleManager.instance.Say("Pas sur que être \nune chance…", personnage, 5,13);
        BulleManager.instance.Say("Allez je vous laisse \ntranquille,\n bonne journée", ScenarioManager.instance.Gaetan, 5,18);

        gaet.SetFocusIn(null, 26);
        personnage.SetFocusIn(null, 26);
    }



    public void RencontreAvecSteven()
    {
        Personne stev = ScenarioManager.instance.Steven;
        personnage.focus = stev;
        stev.focus = personnage;

        BulleManager.instance.Say("Avais-tu des\n questions sur \nla compagnie?", ScenarioManager.instance.Steven, 5);
        BulleManager.instance.Say("Oui, pourquoi Samantha\n travailler ici?", ScenarioManager.instance.Annushka, 5, 5);
        BulleManager.instance.Say("Bonne question, \nc’est Enrique qui\n a insisté pour l’engager", ScenarioManager.instance.Steven, 10, 10);
        BulleManager.instance.Say("Pas très surprenant… \nPas plus macho que lui", ScenarioManager.instance.Annushka, 5, 20);
        BulleManager.instance.Say("Je ne te le\n fais pas dire !", ScenarioManager.instance.Steven, 5, 25);

        stev.SetFocusIn(null, 26);
        personnage.SetFocusIn(null, 26);
    }

    public void DiscussionAvecStephen()
    {
        Personne stephen = ScenarioManager.instance.Stephen;
        personnage.focus = stephen;
        stephen.focus = personnage;

        BulleManager.instance.Say("Tu manges pas?", ScenarioManager.instance.Stephen,3,0);
        BulleManager.instance.Say("Moi seulement boire vodka", personnage, 3, 3);
        BulleManager.instance.Say("On va bien\ns'entendre tous les deux\nalors ", ScenarioManager.instance.Stephen, 8, 8);
        BulleManager.instance.Say("Je pense pas\nnon...", personnage, 3, 16);

        stephen.SetFocusIn(null, 26);
        personnage.SetFocusIn(null, 26);
    }

    public void EntrainementAvecEnrique()
    {
        // TODO : Dialogue
    }

    public void ProblemeAvecOrdinateur()
    {
        BulleManager.instance.Say("Patron incompétant /n Ordinateur brisé ", personnage, 5);
    }

    public void AppelAuToilette()
    {
        AppelTéléphonique newCall = new AppelTéléphonique("Annushka", "Anonyme");
        personnage.SetMyCall(newCall);

        Cell telephone = personnage.GetCell();

        BulleManager.instance.StartCall(personnage, 14);

        telephone.SayInTelephone("Oui Allo?", "Annushka");
        telephone.SayInTelephone("Transférez moi à M.Florez", "Anonyme", 2);
        telephone.SayInTelephone("Aucun M.Florez ici", "Annushka", 4);
        telephone.SayInTelephone("M.Florez, il travaille ici !", "Anonyme", 8);
        telephone.SayInTelephone("Non, patron Rodriguez, mais pas Florez.", "Annushka", 10);
        telephone.SayInTelephone("C'est urgent! M.Florez va commettre une grave erreur ce soir", "Anonyme", 12);
        telephone.SayInTelephone("Désolé, mauvais numéro. Aucun M.Florez ici", "Annushka", 14);

        telephone.EndCall(14);

        ScenarioManager.instance.Annushka.GetCell().AddCall("Anonyme", "30/02/2017 - 17h05");
    }

    public void DemandePourGaetan()
    {
        Personne gaet = ScenarioManager.instance.Gaetan;
        personnage.focus = gaet;
        gaet.focus = personnage;

        BulleManager.instance.Say("Besoin débarrer\n salle entrainement", ScenarioManager.instance.Annushka, 5);
        BulleManager.instance.Say("Aucun problème,\n suis-moi", ScenarioManager.instance.Gaetan, 5, 5);
        BulleManager.instance.Say("Merci monsieur.", ScenarioManager.instance.Annushka, 5, 10);

        gaet.SetFocusIn(null, 11);
        personnage.SetFocusIn(null, 11);
    }

    public void OuvertureDuColis()
    {
        BulleManager.instance.Say("Moi curieuse...\n Que contient colis?", ScenarioManager.instance.Annushka, 3,10);
        BulleManager.instance.Say("Miam bon gâteau\n à la vanille!", ScenarioManager.instance.Annushka, 13);
    }
}
