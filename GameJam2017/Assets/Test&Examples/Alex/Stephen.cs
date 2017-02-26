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
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(515, WayPoint.getWaypoint("BossDesk").position, personnage));
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
        Personne gaet = ScenarioManager.instance.Gaetan;
        personnage.focus = gaet;
        gaet.focus = personnage;

        BulleManager.instance.Say("Salut Gaétan !\n Quoi de neuf?", personnage, 5);
        BulleManager.instance.Say("Hey, j’ai analysé\n la salle de bain\n et la ventilation mène\n directement à la \nsalle de réunion", ScenarioManager.instance.Gaetan, 5, 5);
        BulleManager.instance.Say("Cool, mais inutile\n à savoir non?", personnage, 10, 10);
        BulleManager.instance.Say("Non du tout !\n On pourrait tous\n mourir si quelqu’un\n lançait une attaque\n chimique à partir d’ici", ScenarioManager.instance.Gaetan, 5, 20);
        BulleManager.instance.Say("T’es creep\n mon Gaétan.", personnage, 5, 25);

        gaet.SetFocusIn(null, 26);
        personnage.SetFocusIn(null, 26);
    }

    //10h45 à 10h52 : Surprend Gaétan sur son ordinateur
    public void GaetanSurprise()
    {
        Personne gaet = ScenarioManager.instance.Gaetan;
        personnage.focus = gaet;
        gaet.focus = personnage;

        BulleManager.instance.Say("Hey !\n Touche pas à mon ordi,\n prend celle de la stagiaire", personnage, 5);
        BulleManager.instance.Say("J’mexcuse, j’avais\n juste une recherche\n rapide à faire", ScenarioManager.instance.Gaetan, 5, 5);
        BulleManager.instance.Say("Excuse-toi pas\n pis recommence pu", personnage, 10, 10);

        gaet.SetFocusIn(null, 11);
        personnage.SetFocusIn(null, 11);
    }

    //12h00 à 12h30 : Se plaint de Enrique dû au fait qu’il n’a pas reçu de bonus après sa dernière campagne publicitaire
    public void DiscutionPrime()
    {
        Personne sam = ScenarioManager.instance.Samantha;
        Personne ann = ScenarioManager.instance.Annushka;
        personnage.focus = sam;
        sam.focus = ann;

        BulleManager.instance.Say("J’en reviens pas\n que Enrique a\n dépensé mon bonus\n pour modifier\n sa Civic", personnage, 5);
        BulleManager.instance.Say(" J’ai doublé les\n chiffres de l’entreprise pis\n j’recois pas une cenne", personnage, 5, 5);
        BulleManager.instance.Say("J’mériterais\n au moins 10 000$", personnage, 5, 10);
        BulleManager.instance.Say(": Moi avec 10 000$,\n j’macheterais de nouveaux\n implants mamaires", ScenarioManager.instance.Samantha, 5, 15);
        BulleManager.instance.Say("Tu vois déjà pas\n tes pieds… Toi pas trouver\n ça assez gros?", ScenarioManager.instance.Annushka, 5, 20);

        sam.SetFocusIn(null, 21);
        personnage.SetFocusIn(null, 21);
    }

    //12h40 à 13h00 : Appel téléphonique sur un numéro anonyme. Il demande des informations sur la réunion de ce soir
    public void AppelTel()
    {
        BulleManager.instance.Say("As-tu des informations\n sur la réunion de ce\n soir à me fournir?", ScenarioManager.instance.Stephen, 5);
        BulleManager.instance.Say("***Je n’ai pas\n réussi à accéder aux\n dossiers de ton entreprise.\n Ils sont trop bien protégés***", ScenarioManager.instance.Stephen, 5, 5);
        BulleManager.instance.Say("Ça c’est la faute de Gary !\n J’vais essayer de\n m’arranger avec lui.", ScenarioManager.instance.Stephen, 5, 10);
        BulleManager.instance.Say("***Fais vite,\n sinon ton plan va échouer***", ScenarioManager.instance.Stephen, 5, 15);
    }

    //13h10 à 13h20 : Cogne à la porte, sans réponse
    public void TocGary()
    {
        BulleManager.instance.Say("*Frappe à la porte*", ScenarioManager.instance.Stephen, 5);
    }

    //Rencontre Gaétan (15h30):
    public void GaetanBlabla()
    {
        Personne gaet = ScenarioManager.instance.Gaetan;
        personnage.focus = gaet;
        gaet.focus = personnage;

        BulleManager.instance.Say("As-tu une femme\n et des enfants toi Gaétan?", personnage, 5);
        BulleManager.instance.Say("Non, les femmes\n m’intéressent pas", ScenarioManager.instance.Gaetan, 5, 5);
        BulleManager.instance.Say("Attends quoi?\n T’aimes les hommes?", personnage, 5, 10);
        BulleManager.instance.Say("Pas les hommes,\n 1 seul…", ScenarioManager.instance.Gaetan, 5, 15);

        gaet.SetFocusIn(null, 16);
        personnage.SetFocusIn(null, 16);
    }

    //17h45 à 18h00 : Appel téléphonique sur le fait qu’il ignore l’identité du dirigeant qui vient visiter ce soir. Il aurait aimé ça le savoir pour faire ses recherches et l’impressionner et espérer obtenir un meilleur poste à la direction (PREUVE INNOCENCE)
    public void AppelTel2()
    {
        BulleManager.instance.Say("***As-tu réussi\n à obtenir ce que\n tu voulais***", ScenarioManager.instance.Stephen, 5);
        BulleManager.instance.Say("Non, le geek\n me demande 1000$ pour\n son foutu document", ScenarioManager.instance.Stephen, 5, 5);
        BulleManager.instance.Say("***Donne lui,\n ça vaut la peine***", ScenarioManager.instance.Stephen, 5, 10);
        BulleManager.instance.Say("J’ai pas 1000$\n sur moi pis j’ai\n pas le temps d’aller\n le retirer avant 18h30…", ScenarioManager.instance.Stephen, 5, 15);
    }
}
