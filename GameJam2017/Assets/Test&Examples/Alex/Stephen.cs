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
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(90,EnriqueRencontre ));
        //10H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(120, WayPoint.getWaypoint("SalleDesEmployes").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(130,StevenConv1 ));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(140, WayPoint.getWaypoint("StephenDesk").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(172,GaetanSurprise ));
        //11H
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(190,StevenConv2 ));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(230, WayPoint.getWaypoint("SalleDesEmployes").position, personnage));
        //12H
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(240,DiscutionPrime));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(270, WayPoint.getWaypoint("WCBlue").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(280,AppelTel));
        //13H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(300, WayPoint.getWaypoint("InformaticienDesk").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(310,TocGary ));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(320, WayPoint.getWaypoint("StephenDesk").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(330,MailAskGary ));
        //14H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(360, WayPoint.getWaypoint("SalleDesEmployes").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(370, StevenConv3));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(400, WayPoint.getWaypoint("SalleDesEmployes").position, personnage));

        //15H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(420, WayPoint.getWaypoint("SalleEntrainement").position, personnage));
        //16H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(515, WayPoint.getWaypoint("BossDesk").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(525,StevenConv4 ));
        //17H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(540, WayPoint.getWaypoint("InformaticienDesk").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(555,GaryAsk ));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(585, WayPoint.getWaypoint("StephenDesk").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(585,AppelTel2 ));
        //18H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(615, WayPoint.getWaypoint("SalleReunionSud").position, personnage));
    }

    //8h40 à 9h15 : Toilettes des hommes et discussion avec Gaétan
    public void GaetanConv()
    {

    }

    //9h30 à 10h00 : Rencontre avec Enrique
    public void EnriqueRencontre()
    {

    }

    //10h10 à 10h20 : Discussion avec son frère Steven sur Enrique
    public void StevenConv1()
    {

    }

    //10h45 à 10h52 : Surprend Gaétan sur son ordinateur
    public void GaetanSurprise()
    {

    }

    //11h10 à 11h50 : Discussion avec Steven portant sur Enrique
    public void StevenConv2()
    {

    }

    //12h00 à 12h30 : Se plaint de Enrique dû au fait qu’il n’a pas reçu de bonus après sa dernière campagne publicitaire
    public void DiscutionPrime()
    {

    }

    //12h40 à 13h00 : Appel téléphonique sur un numéro anonyme. Il demande des informations sur la réunion de ce soir
    public void AppelTel()
    {

    }

    //13h10 à 13h20 : Cogne à la porte, sans réponse
    public void TocGary()
    {

    }

    //13h30 à 14h00 : Lecture de ses courriels et demande à Gary d’obtenir des infos sur la réunion de ce soir
    public void MailAskGary()
    {

    }

    //14h10 à 14h40 : discution avec Steven
    public void StevenConv3()
    {

    }

    //16h45 à 17h00 : Steven va annoncer à Stephen que le colis sera prêt à 18h00 dans la salle d’entrainement
    public void StevenConv4()
    {

    }

    //17h15 à 17h30: Veut le rapport, mais il n’a pas eu le temps d’aller retirer l’argent
    public void GaryAsk()
    {

    }

    //17h45 à 18h00 : Appel téléphonique sur le fait qu’il ignore l’identité du dirigeant qui vient visiter ce soir. Il aurait aimé ça le savoir pour faire ses recherches et l’impressionner et espérer obtenir un meilleur poste à la direction (PREUVE INNOCENCE)
    public void AppelTel2()
    {

    }
}
