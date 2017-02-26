using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stephen : Brain {

    public override void ToDo()
    {
        //8H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(0, WayPoint.getWaypoint("StephenDesk").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(30, WayPoint.getWaypoint("WCBlue").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(40,GaetanConv));
        //9H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(75, WayPoint.getWaypoint("BossDesk").position, personnage));
        //10H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(120, WayPoint.getWaypoint("SalleDesEmployes").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(140, WayPoint.getWaypoint("StephenDesk").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(172,GaetanSurprise ));
        //11H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(230, WayPoint.getWaypoint("SalleDesEmployes").position, personnage));
        //12H
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(240,DiscutionPrime));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(270, WayPoint.getWaypoint("WCBlue").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(280,AppelTel));
        //13H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(300, WayPoint.getWaypoint("InformaticienDesk").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(310,TocGary ));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(320, WayPoint.getWaypoint("StephenDesk").position, personnage));
        //14H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(360, WayPoint.getWaypoint("SalleDesEmployes").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(400, WayPoint.getWaypoint("SalleDesEmployes").position, personnage));

        //15H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(420, WayPoint.getWaypoint("SalleEntrainement").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(450, GaetanBlabla));
        //16H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(515, WayPoint.getWaypoint("BossDeck").position, personnage));
        //17H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(540, WayPoint.getWaypoint("InformaticienDesk").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(585, WayPoint.getWaypoint("StephenDesk").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(585,AppelTel2 ));
        //18H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(615, WayPoint.getWaypoint("SalleReunionSud").position, personnage));
    }

    //8h40 à 9h15 : Toilettes des hommes et discussion avec Gaétan
    public void GaetanConv()
    {
        BulleManager.instance.Say("Salut Gaétan ! Quoi de neuf?", ScenarioManager.instance.Stephen, 5);
        BulleManager.instance.Say("Hey, j’ai analysé la salle de bain et la ventilation mène directement à la salle de réunion", ScenarioManager.instance.Gaetan, 5, 5);
        BulleManager.instance.Say("Cool, mais inutile à savoir non?", ScenarioManager.instance.Stephen, 10, 10);
        BulleManager.instance.Say("Non du tout ! On pourrait tous mourir si quelqu’un lançait une attaque chimique à partir d’ici", ScenarioManager.instance.Gaetan, 5, 20);
        BulleManager.instance.Say("T’es creep mon Gaétan.", ScenarioManager.instance.Stephen, 5, 25);

    }

    //10h45 à 10h52 : Surprend Gaétan sur son ordinateur
    public void GaetanSurprise()
    {
        BulleManager.instance.Say("Hey ! Touche pas à mon ordi, prend celle de la stagiaire", ScenarioManager.instance.Stephen, 5);
        BulleManager.instance.Say("J’mexcuse, j’avais juste une recherche rapide à faire", ScenarioManager.instance.Gaetan, 5, 5);
        BulleManager.instance.Say("Excuse-toi pas pis recommence pu", ScenarioManager.instance.Stephen, 10, 10);

    }

    //12h00 à 12h30 : Se plaint de Enrique dû au fait qu’il n’a pas reçu de bonus après sa dernière campagne publicitaire
    public void DiscutionPrime()
    {
        BulleManager.instance.Say("J’en reviens pas que Enrique a dépensé mon bonus pour modifier sa Civic", ScenarioManager.instance.Stephen, 5);
        BulleManager.instance.Say(" J’ai doublé les chiffres de l’entreprise pis j’recois pas une cenne", ScenarioManager.instance.Stephen, 5, 5);
        BulleManager.instance.Say("J’mériterais au moins 10 000$", ScenarioManager.instance.Stephen, 5, 10);
        BulleManager.instance.Say(": Moi avec 10 000$, j’macheterais de nouveaux implants mamaires", ScenarioManager.instance.Samantha, 5, 15);
        BulleManager.instance.Say("Tu vois déjà pas tes pieds… Toi pas trouver ça assez gros?", ScenarioManager.instance.Annushka, 5, 20);

    }

    //12h40 à 13h00 : Appel téléphonique sur un numéro anonyme. Il demande des informations sur la réunion de ce soir
    public void AppelTel()
    {
        BulleManager.instance.Say("As-tu des informations sur la réunion de ce soir à me fournir?", ScenarioManager.instance.Stephen, 5);
        BulleManager.instance.Say("***Je n’ai pas réussi à accéder aux dossiers de ton entreprise. Ils sont trop bien protégés***", ScenarioManager.instance.Stephen, 5, 5);
        BulleManager.instance.Say("Ça c’est la faute de Gary ! J’vais essayer de m’arranger avec lui.", ScenarioManager.instance.Stephen, 5, 10);
        BulleManager.instance.Say("***Fais vite, sinon ton plan va échouer***", ScenarioManager.instance.Stephen, 5, 15);
    }

    //13h10 à 13h20 : Cogne à la porte, sans réponse
    public void TocGary()
    {
        BulleManager.instance.Say("*Frappe à la porte*", ScenarioManager.instance.Stephen, 5);
    }

    //Rencontre Gaétan (15h30):
    public void GaetanBlabla()
    {
        BulleManager.instance.Say("As-tu une femme et des enfants toi Gaétan?", ScenarioManager.instance.Stephen, 5);
        BulleManager.instance.Say("Non, les femmes m’intéressent pas", ScenarioManager.instance.Gaetan, 5, 5);
        BulleManager.instance.Say("Attends quoi? T’aimes les hommes?", ScenarioManager.instance.Stephen, 5, 10);
        BulleManager.instance.Say("Pas les hommes, 1 seul…", ScenarioManager.instance.Gaetan, 5, 15);
    }

    //17h45 à 18h00 : Appel téléphonique sur le fait qu’il ignore l’identité du dirigeant qui vient visiter ce soir. Il aurait aimé ça le savoir pour faire ses recherches et l’impressionner et espérer obtenir un meilleur poste à la direction (PREUVE INNOCENCE)
    public void AppelTel2()
    {
        BulleManager.instance.Say("***As-tu réussi à obtenir ce que tu voulais***", ScenarioManager.instance.Stephen, 5);
        BulleManager.instance.Say("Non, le geek me demande 1000$ pour son foutu document", ScenarioManager.instance.Stephen, 5, 5);
        BulleManager.instance.Say("***Donne lui, ça vaut la peine***", ScenarioManager.instance.Stephen, 5, 10);
        BulleManager.instance.Say("J’ai pas 1000$ sur moi pis j’ai pas le temps d’aller le retirer avant 18h30…", ScenarioManager.instance.Stephen, 5, 15);
    }
}
