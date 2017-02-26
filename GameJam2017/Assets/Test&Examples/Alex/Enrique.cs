using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enrique : Brain {

    public override void ToDo()
    {
        //8H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(0, WayPoint.getWaypoint("BossDesk").position, personnage));
        //9H      
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(90, ConvStephen));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(116, WayPoint.getWaypoint("InformaticienDesk").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(124, knockDoor));
        //10H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(130, WayPoint.getWaypoint("SalleEntrainement_Bench").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(146, WayPoint.getWaypoint("BossDesk").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(156, ConvJustine));
        //11H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(195, WayPoint.getWaypoint("WCBlue").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(210, ConvStephen));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(225, WayPoint.getWaypoint("PlacardConsierge").position, personnage));
        //12H

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(245, WayPoint.getWaypoint("BossDesk").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(250, GaryCall));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(280, WayPoint.getWaypoint("SalleEntrainement_Bench").position, personnage));
        //13H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(320, WayPoint.getWaypoint("BossDesk").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(350, WayPoint.getWaypoint("SalleEntrainement_Bench").position, personnage));
        //14H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(395, WayPoint.getWaypoint("BossDesk").position, personnage));
        //15H
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(420, ConvSteven2));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(450, ConvJustine2));
        //16H
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(480, StephenConv));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(510, AppelGary));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(530, AppelSamantha));
        //18H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(620, WayPoint.getWaypoint("SalleReunionEnrique").position, personnage));
    }

    //Rencontre avec Stephen (9h30):
    public void ConvStephen()
    {

        Personne Stephen = ScenarioManager.instance.Stephen;
        personnage.focus = Stephen;
        Stephen.focus = personnage;

        BulleManager.instance.Say("Je tenais à te féliciter\n pour ta dernière campagne\n marketing. Nos chiffres de ventes\n ont doublé depuis", personnage, 5);
        BulleManager.instance.Say("C’est ça qui\n arrive quand on engage\n le meilleur dans le domaine,\n alors c’est combien mon bonus?", Stephen, 5, 5);
        BulleManager.instance.Say("Ton bonus?\n J’ai pas de bonus à te donner\n j’ai toute dépenser\n pour modifier ma Civic", personnage, 5, 10);
        BulleManager.instance.Say("T’es sérieux Enrique?\n J’serais tellement \nun meilleur boss que toi…", Stephen, 5, 15);

        Stephen.SetFocusIn(null, 26);
        personnage.SetFocusIn(null, 26);
    }

    public void knockDoor()
    {
        personnage.defaultDirection = Character.Direction.Up;
        personnage.SetDirectionIn(Character.Direction.Down, 7);
    }

    //Conversation avec Justine (10h45) :
    public void ConvJustine()
    {

        Personne Justine = ScenarioManager.instance.Justine;
        personnage.focus = Justine;
        Justine.focus = personnage;

        BulleManager.instance.Say("Ma belle Justine,\n peux-tu ben me dire\n pourquoi tu ne renouvelles pas\n ton contrat avec nous?", personnage, 5);
        BulleManager.instance.Say("J’ai besoin\n de nouveaux défis Enrique,\n j’ten ai déjà parlé.", Justine, 5, 5);
        BulleManager.instance.Say("Je sais,\n mais tu dois comprendre\n que je peux pas laisser\n quelqu’un d’autre\n profiter de ton talent", personnage, 5, 10);
        BulleManager.instance.Say("C’est pas vraiment\n comme si t’avais le\n choix rendu là", Justine, 5, 15);
        BulleManager.instance.Say("On va voir après ce soir\n si tu penses encore ça….", personnage, 5, 20);

        Justine.SetFocusIn(null, 26);
        personnage.SetFocusIn(null, 26);
    }

    //Discussion avec Steven (11h30) :
    public void ConvSteven()
    {
        Personne Steven = ScenarioManager.instance.Steven;
        personnage.focus = Steven;
        Steven.focus = personnage;

        BulleManager.instance.Say("Hey Enrique,\n Stephen m’a parlé\n de l’histoire du bonus\n pis de ta Civic", Steven, 5);
        BulleManager.instance.Say("J’veux pas te dire quoi faire,\n mais j’suis pas sûr que\n c’est la meilleure façon\n de garder tes employés", Steven, 5, 5);
        BulleManager.instance.Say("C’est moi le boss,\n j’fais ce que je veux.\n J’ai besoin de ma Civic pour\n me pogner des chickitas.", personnage, 5, 10);
        BulleManager.instance.Say("Tu devrais surveiller ton attitude,\n à force de jouer avec le feu,\n on finit par se brûler", Steven, 5, 15);

        Steven.SetFocusIn(null, 26);
        personnage.SetFocusIn(null, 26);
    }

    //Appel de Gary (12h10) 
    public void GaryCall()
    {
        //TODOAppel
    }

    //Rencontre avec Steven (15h00) :
    public void ConvSteven2()
    {
        Personne Steven = ScenarioManager.instance.Steven;
        personnage.focus = Steven;
        Steven.focus = personnage;

        BulleManager.instance.Say("Écoute j’ai reçu un courriel\n d’un ancien employeur de Justine.\n Il m’a dit qu’on devrait se méfier d’elle,\n surtout vers la fin de son contrat.", Steven, 5);
        BulleManager.instance.Say("De quoi se\n méfier d’elle?", personnage, 5, 5);
        BulleManager.instance.Say("Il ne m’a pas donné plus d’informations,\n on devrait-tu questionner Justine?", Steven, 5, 10);
        BulleManager.instance.Say("Non, je la rencontre\n dans quelques minutes,\n je vais m’en charger", personnage, 5, 15);

        Steven.SetFocusIn(null, 26);
        personnage.SetFocusIn(null, 26);
    }

    //Rencontre avec Justine (15h30) :
    public void ConvJustine2()
    {
        Personne Justine = ScenarioManager.instance.Justine;
        personnage.focus = Justine;
        Justine.focus = personnage;

        BulleManager.instance.Say("Sois honnête Justine,\n est-ce que je devrais\n me méfier de toi?", personnage, 5);
        BulleManager.instance.Say("Quoi? Ben non voyons,\n c’est qui qui t’as mis\n ça dans la tête?\n Mon ancien boss?", Justine, 5, 5);
        BulleManager.instance.Say("Non non, c’était juste\n une question comme ça…", personnage, 5, 10);
        BulleManager.instance.Say("Donc j’aimerais que\n tu me complètes le rapport\n sur NOMCOMPAGNIE pour 18h", personnage, 5, 15);
        BulleManager.instance.Say("Aucun problème,\n je me met là-dessus pour\n les prochaines heures", Justine, 5, 20);

        Justine.SetFocusIn(null, 26);
        personnage.SetFocusIn(null, 26);
    }

    //Rencontre avec Stephen (16h00) :
    public void StephenConv()
    {
        Personne Stephen = ScenarioManager.instance.Stephen;
        personnage.focus = Stephen;
        Stephen.focus = personnage;

        BulleManager.instance.Say("La rencontre est dans 2h\n pis j’ai aucune information\n sur la compagnie !", Stephen, 5);
        BulleManager.instance.Say("Comment tu veux j’fasse\n ma job si tu me laisses\n dans l’ombre?", Stephen, 5, 5);
        BulleManager.instance.Say("Calme toi Stephen,\n tout est sous contrôle\n fais-moi confiance\n pour une fois", personnage, 5, 10);
        BulleManager.instance.Say("Toi tu devrais me faire confiance,\n crois-moi, si j’étais le boss\n ça se passerait pas de même", Stephen, 5, 15);
        BulleManager.instance.Say("Sauf que\n c’est moi le boss", personnage, 5, 20);
        BulleManager.instance.Say("Pour combien de temps?", Stephen, 5, 25);

        Stephen.SetFocusIn(null, 26);
        personnage.SetFocusIn(null, 26);
    }

    //Appel avec Gary(16h30) :
    public void AppelGary()
    {
        //TODO
    }

    //Appel Samantha (16h50) :
    public void AppelSamantha()
    {
        //TODO
    }


   
}
