using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Samantha : Brain {

    public override void ToDo()
    {
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(0, WayPoint.getWaypoint("SamanthaDesk").position, personnage)); // 8h00 a 8h10

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(10, MakeTexto1));                                             // 8h10 a 8h30

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(30, WayPoint.getWaypoint("BossDesk_Visiteur1").position, personnage)); // 8h30 a 8h40

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(31, TurnTop1));

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(40, Drague1));                                           // 8h40 a 9h00

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(60, WayPoint.getWaypoint("SamanthaDesk").position, personnage)); // 9h00 a 9h10

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(70, TravailPersonnel)); // 9h10 a 9h30

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(90, WayPoint.getWaypoint("AnnushkaDesk_Visiteur").position, personnage)); // 9h30 a 9h40

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(91, TurnTop1));

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(100, ParleAvecAnn)); // 9h40 a 10h10

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(117, WayPoint.getWaypoint("WCRed_Miroir").position, personnage)); // 10h10 a 10h15

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(124, Maquillage)); // 10h15 a 11h00

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(165, WayPoint.getWaypoint("BossDesk_Visiteur1").position, personnage)); // 11h00 a 11h20

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(172, TurnTop1));

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(184, Drague2)); // 11h20 a 11h50

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(210, WayPoint.getWaypoint("SalleDesEmployes_Samantha").position, personnage)); // 11h50 a 12h00

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(240, EcouteStephen)); // 12h00 a 12h30

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(263, WayPoint.getWaypoint("SamanthaDesk").position, personnage)); // 12h30 a 12h35

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(270, TravailPersonnel1)); // 12h00 a 12h30

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(275, MakeTexto2)); // 12h35 a 13h00

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(300, WayPoint.getWaypoint("BossDesk_Visiteur1").position, personnage)); // 13h00 a 13h10

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(301, TurnTop2));

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(310, MemoBoss)); // 13h10 a 13h15

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(315, WayPoint.getWaypoint("BossDesk_Visiteur2").position, personnage)); // 13h15 a 13h20


        ScenarioEventManager.AddEvent(new ActionScenarioEvent(317, Pre_RemoveMemoBoss)); // 13h10 a 13h15

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(318, RemoveMemoBoss)); // 13h10 a 13h15

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(320, WayPoint.getWaypoint("AnnushkaDesk_Visiteur").position, personnage)); // 13h20 a 13h30

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(325, TurnTop1));

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(330, ParleAvecAnn2)); // 13h30 a 13h55

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(355, WayPoint.getWaypoint("SamanthaDesk").position, personnage)); // 13h55 a 14h05

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(365, ParleAvecJustine)); // 14h05 a 14h30

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(390, WayPoint.getWaypoint("BossDesk_Visiteur1").position, personnage)); // 14h30 a 14h40

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(400, TurnTop)); // 14h40 a 15h30

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(400, Drague3)); // 14h40 a 15h30

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(450, WayPoint.getWaypoint("PlacardConsierge").position, personnage)); // 15h30 a 15h40

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(460, PrendEauJavel)); // 15h40 a 16h00

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(480, WayPoint.getWaypoint("SamanthaDesk").position, personnage)); // 16h00 a 16h07

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(487.5f, WayPoint.getWaypoint("StephenDesk").position, personnage)); // 16h07 a 16h15

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(495, InviteStephen)); // 16h15 a 16h45

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(500, TravailPersonnel));

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(525, WayPoint.getWaypoint("SamanthaDesk").position, personnage)); // 16h45 a 16h50

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(530, SiteWebJavel)); // 16h50 a 17h10

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(550, Appel_M_X)); // 17h10 a 17h30

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(570, WayPoint.getWaypoint("SalleDesEmployes_Samantha").position, personnage)); // 17h30 a 17h40

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(580, PrepareUnCofee)); // 17h40 a 18h00

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(600, WayPoint.getWaypoint("SamanthaDesk").position, personnage)); // 18h00 a 18h05

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(605, PrepareUnCofee)); // 18h05 a 18h15

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(615, WayPoint.getWaypoint("SalleReunionSamantha").position, personnage)); // 18h15 a 18h30
    }

    public void TurnTop2()
    {
        personnage.defaultDirection = Character.Direction.Up;
        personnage.SetDirectionIn(Character.Direction.Down, 20);
    }

    public void TurnTop1()
    {
        personnage.defaultDirection = Character.Direction.Up;
        personnage.SetDirectionIn(Character.Direction.Down, 30);
    }


    public void TurnTop()
    {
        personnage.defaultDirection = Character.Direction.Up;
        personnage.SetDirectionIn(Character.Direction.Down, 55);
    }

    public void MakeTexto1()
    {
        personnage.GetCell().AddTexto("T'en reviendras pas Natasha, Enrique porte sa cravate rouge aujourd'hui. Y sait clairement que c'est ma préférée en plus", "8h10", "Enrique");
        personnage.GetCell().AddTexto("Oops lis pas le dernier message, c'était pas pour toi !", "8h10", "Enrique");
        personnage.GetCell().AddTexto("T'en reviendras pas Natasha, Enrique porte sa cravate rouge aujourd'hui. Y sait clairement que c'est ma préférée en plus", "8h10", "Natasha");
    }

    public void Drague1()
    {
        Personne Enrique = ScenarioManager.instance.Enrique;
        personnage.focus = Enrique;
        Enrique.focus = personnage;

        BulleManager.instance.Say("Salut mon beau! \n Grosse journée en vue? \n Belle cravate en passant.",personnage, 5);
        BulleManager.instance.Say("Merci Samantha, \n T'oublie pas de confirmer \nla réunion de ce soir?", Enrique, 5, 5);
        BulleManager.instance.Say("Bien sûr que non, \n j'voudrais pas décevoir\n mon minou.", personnage, 5, 10);

        Enrique.SetFocusIn(null, 11);
        personnage.SetFocusIn(null, 11);
    }

    public void TravailPersonnel1()
    {
        ClavierAnimation(30);
    }

    public void TravailPersonnel()
    {
        ClavierAnimation(20);
    }

    public void ParleAvecAnn()
    {
        personnage.focus = ScenarioManager.instance.Annushka;
        ScenarioManager.instance.Annushka.focus = personnage;


        BulleManager.instance.Say("Là on va mettre\n quelque chose au \nclair Annishma", personnage, 4,0);
        BulleManager.instance.Say("Annushka, mon \nnom est Annushka", ScenarioManager.instance.Annushka, 3, 4);
        BulleManager.instance.Say("Même affaire... \nEnrique c'est mon \nchérie donc pas \ntouche!", personnage, 5, 7);
        BulleManager.instance.Say("Toi pouvoir le \ngarder, moi pas \ninteressé par gros \nmacho", ScenarioManager.instance.Annushka, 5, 12);

        ScenarioManager.instance.Annushka.SetFocusIn(null, 17);
        personnage.SetFocusIn(null, 17);
    }

    public void Maquillage()
    {
        personnage.defaultDirection = Character.Direction.Up;
        personnage.SetDirectionIn(Character.Direction.Down, 42);
    }

    public void Drague2()
    {
        Personne Enrique = ScenarioManager.instance.Enrique;
        personnage.focus = Enrique;
        Enrique.focus = personnage;

        BulleManager.instance.Say("*Voix sensuelle* \nHola Enrique.", personnage, 3,0);
        BulleManager.instance.Say("J'ai pas vraiment \nle temps Samantha", Enrique, 3, 3);
        BulleManager.instance.Say("Oublie pas de \nconfirmer la réunion \nde ce soir", Enrique, 3, 6);
        BulleManager.instance.Say("Non non \nInquiètes pas toi", personnage, 3, 9);
 
        Enrique.SetFocusIn(null, 12);
        personnage.SetFocusIn(null, 12);
    }

    public void EcouteStephen()
    {

    }

    public void MakeTexto2()
    {
        personnage.GetCell().AddTexto("Après la petite fête surprise de ce soir, on pourrait aller prendre un verre? J'inviterai Enriques se joindre à nous ;)", "12h35", "Natasha");
    }

    public void MemoBoss()
    {
        ScenarioManager.instance.FeuilleAmourSamantha.gameObject.SetActive(true);
    }

    public void Pre_RemoveMemoBoss()
    {
        BulleManager.instance.Say("Pfff...\n Enrique est à moi!", personnage, 2.5f, 0);
    }

    public void RemoveMemoBoss()
    {
        ScenarioManager.instance.FeuilleAmourGaetan.gameObject.SetActive(false);
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
        AppelTéléphonique newCall = new AppelTéléphonique("Samantha", "Anonyme");
        personnage.SetMyCall(newCall);

        Cell telephone = personnage.GetCell();

        BulleManager.instance.StartCall(personnage, 10);

        telephone.SayInTelephone("Oui Allo?", "Samantha");
        telephone.SayInTelephone("Bonjour Luis, c'était seulement pour confirmer votre rendez-vous avec notre PDG, ce soir 18h30.", "Luis", 2);
        telephone.SayInTelephone("Oui, je serais la à l'heure. C'est bien au 3ieme étape?", "Samantha", 4);
        telephone.SayInTelephone("Oui, 3ième étage.", "Luis", 6);
        telephone.SayInTelephone("Parfait.", "Samantha", 8);
        telephone.SayInTelephone("Merci et au plaisir de vous rencontrer", "Luis", 10);

        telephone.EndCall(10);
    }

    public void PrepareUnCofee()
    {

    }
}
